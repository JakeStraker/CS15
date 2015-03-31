using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Group_Stegonography_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "Bitmap Pictures (.bmp)|*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            Globals.filepath = openFileDialog1.FileName;
            FileStream fs = new FileStream(Globals.filepath, FileMode.Open);
            Globals.currentImage = (Bitmap)Image.FromStream(fs);
            fs.Close();
            pBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxMain.Image = Globals.currentImage;
            pBoxMain.Refresh();
            Globals.selectedImage = true;
            Globals.imgHeight = Globals.currentImage.Height;
            Globals.imgWidth = Globals.currentImage.Width;
            lblImgSize.Text = "Size = (" + Globals.imgWidth + " x " + Globals.imgHeight + ")";
            Globals.maxChar = (int)(Math.Truncate((double)(((Globals.imgHeight * Globals.imgWidth) * 3) / 8)));
            lblFileMax.Text = "Max Chars = " + Globals.maxChar;

        }

        private void btnEmbed_Click(object sender, EventArgs e)
        {
            if (Globals.selectedImage == true && txtSecretText.Text.Length < Globals.maxChar)
            {
                Globals.currentImage = functions.embedMessage(txtSecretText.Text, Globals.currentImage);
                pBoxMain.Image = Globals.currentImage;
                pBoxMain.Refresh();
                System.IO.File.Delete(Globals.filepath);
                Globals.currentImage.Save(Globals.filepath,System.Drawing.Imaging.ImageFormat.Bmp);
            }
            else
            {
                if (Globals.selectedImage == true)
                {
                    MessageBox.Show("You are trying to embed more than the max characters");
                }
                else
                {
                    MessageBox.Show("You have not selected an Image");
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            MessageBox.Show(functions.extractMessage(Globals.currentImage));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSecretText.Clear();
        }

        private void stripFile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    public static class Globals
    {
        public static bool selectedImage = false;
        public static Bitmap currentImage;
        public static string filepath = null;
        public static int imgHeight = 0;
        public static int imgWidth = 0;
        public static int maxChar = 0;
    }

    public static class functions
    {
         public enum Embedding //we will only have two states for the embedding function, Adding real data (text) and data to signify the end (footer)
        {
            Text,
            Footer
        };
        public static Bitmap embedMessage(string text, Bitmap image)
        {
            Embedding doingNow = Embedding.Text;
            int charCounter = 0, asciiVal = 0, zeros = 0, R = 0, G = 0, B = 0, bitcounter = 0;
            for (int y = 0; y < Globals.imgHeight; y++)
            {
                // pass through each column
                for (int x = 0; x < Globals.imgWidth; x++)
                {   // Each pixel will contain multiple colours, so we need an object (a colour in this case) to manipulate
                    //MixedColours will hold the values of pixel currently being used
                    Color pixel = image.GetPixel(x, y);

                    //we need to pre-emptitively clear the values of the Least Significant Bit of each colour
                    //this function takes a number and subtracts its least significant bit from itself, resulting in the least significant bit being zero
                    functions.removeLSB(pixel.R, pixel.G, pixel.B, out R, out G, out B);
                    for (int n = 0; n < 3; n++) //do 3 times per bit, using 3 colours
                    {
                        if (newChar(bitcounter) == true) // check if a character(made of 8 bits) has finished being added (or this is the first instance)
                        {
                            // check if the whole process has finished
                            // The function is finished when the footer has finished being added (8 zero's)
                            if (doingNow == Embedding.Footer && zeros == 8)
                            {
                                //if a pixel is only partially covered by a zeros (e.g the last 2 bits of a byte but the third bit (blue) isnt used)
                                //this will make sure that pixel is saved.
                                if ((bitcounter - 1) % 3 < 2)
                                {
                                    image.SetPixel(x, y, Color.FromArgb(R,G,B));
                                }
                                // return the bitmap with the text hidden in
                                return image;
                            }
                            if (charCounter >= text.Length)
                            {
                                doingNow = Embedding.Footer; // start adding the footer padding to the image (8 zeros)
                            }
                            if (charCounter < text.Length)
                            {
                                asciiVal = text[charCounter++];
                            }

                        }
                        switch (bitcounter % 3)
                        {
                            case 0:
                                {
                                    if (doingNow == Embedding.Text)
                                    {
                                        embedBit(ref asciiVal, ref R);
                                    }
                                    
                                }break;
                            case 1:
                                {
                                    if (doingNow == Embedding.Text)
                                    {
                                        embedBit(ref asciiVal, ref G);
                                    }
                                    
                                }break;
                            case 2:
                                {
                                    if (doingNow == Embedding.Text)
                                    {
                                        embedBit(ref asciiVal, ref B);
                                    }
                                    image.SetPixel(x, y, Color.FromArgb(R, G, B)); //after the last colour value (blue) has been changed, we can store the new pixel in the image
                                    
                                }break;
                        }
                        bitcounter++;
                        if (doingNow == Embedding.Footer)
                        {
                            zeros++; //keep incrementing zeros until the if (doingNow == Embedding.Footer && zeros == 8) statement is triggered to return the image
                        }
                    }

                }
            }
            return image;
        }
        public static string extractMessage(Bitmap image)
        {
            int bitCounter = 0, asciiVal = 0;
            StringBuilder extractedText = new StringBuilder();
            // For each row (in the pixel grid) in the image
            for (int y = 0; y < Globals.imgHeight; y++)
            {
                // Go through every column
                for (int x = 0; x < Globals.imgWidth; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    // for each pixel, run this loop 3 times (representing the 3 colours)
                    for (int n = 0; n < 3; n++)
                    {
                        switch (bitCounter % 3)
                        {
                            case 0:
                                {
                                    extractBit(ref asciiVal, pixel.R);
                                } break;
                            case 1:
                                {
                                    extractBit(ref asciiVal, pixel.G);
                                } break;
                            case 2:
                                {
                                    extractBit(ref asciiVal, pixel.B);
                                } break;
                        }

                        bitCounter++;

                        if (newChar(bitCounter) == true)
                        {
                            asciiVal = reverseBits(asciiVal);
                            if (asciiVal == 0)
                            {
                                return extractedText.ToString();
                            }
                            else
                            {
                                char c = (char)asciiVal;
                                extractedText.Append(c);
                            }
                        }
                    }
                }
            }
            return "Error: something must have went really wrong here \n (This is most likely not embedded text)";
        }
        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }
        public static void removeLSB(int baseR, int baseG, int baseB, out int R, out int G, out int B)
        {
            R = baseR - baseR % 2;
            G = baseG - baseG % 2;
            B = baseB - baseB % 2;
        }
        public static bool newChar(int count)
        {
            if (count % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void embedBit(ref int ascii, ref int colourVal)
        {
            //if we are not adding text (ergo are adding the footer padding) then nothing needs to be added (the LSB has already been cleared)
            colourVal += ascii % 2;//the rightmost bit in any binary number (lets call it x) can be found by carrying out x mod 2.
            ascii = ascii / 2;//binary division by 2 represents a bit shift, by moving the numbers one to the right, the next bit of the character can be added using the mod 2 function
            //(01101100/2) = 00110110
        }
        public static void extractBit(ref int ascii, int colourVal)
        {
            //multiplication by 2 in binary, similarly to division induces a shift, this case in to the left
            //(00110110*2) = 01101100
            //the rightmost bit in any binary number (x) can be found by carrying out x mod 2., so by adding it, 
            //after multiplication by 2 we are making the newly opened up LSB equal to the LSB of the pixels colour value
            ascii = ascii * 2 + colourVal % 2;
        }
    } 
    }
