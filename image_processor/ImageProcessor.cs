using System;
using System.Drawing;
using System.Threading.Tasks;

public class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        // Process each image file in parallel
        Parallel.ForEach(filenames, ProcessImage);
    }

    private static void ProcessImage(string filename)
    {
        try
        {
            // Load the original image
            using (Bitmap originalImage = new Bitmap(filename))
            {
                // Create a new bitmap for the inverted image
                Bitmap invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

                // Process each pixel in parallel
                Parallel.For(0, originalImage.Width, x =>
                {
                    for (int y = 0; y < originalImage.Height; y++)
                    {
                        // Get the original pixel color
                        Color originalColor = originalImage.GetPixel(x, y);

                        // Calculate the inverse color
                        Color inverseColor = Color.FromArgb(
                            255 - originalColor.R,
                            255 - originalColor.G,
                            255 - originalColor.B
                        );

                        // Set the pixel in the inverted image
                        invertedImage.SetPixel(x, y, inverseColor);
                    }
                });

                // Save the inverted image with a new filename
                string inverseFilename = GetInverseFilename(filename);
                invertedImage.Save(inverseFilename, originalImage.RawFormat);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing {filename}: {ex.Message}");
        }
    }

    private static string GetInverseFilename(string originalFilename)
    {
        // Generate a new filename for the inverse image
        string extension = System.IO.Path.GetExtension(originalFilename);
        string filenameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(originalFilename);
        return $"{filenameWithoutExtension}_inverse{extension}";
    }
}
