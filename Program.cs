using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImageNameandMetadataChanger
{
    class Program
    {

        static void Main(string[] args)
        {
            /// <summary>
            /// Generates a random name for a file 4-20 characters long.
            /// </summary>
            /// <returns>A string with the random name.</returns>
            String randomName()
            {
                StringBuilder ranName = new StringBuilder();

                //randomizing name generator
                Random r = new Random();
                int rInt = r.Next(4, 21);

                Random l = new Random();

                for (int i = 0; i < rInt; i++)
                {
                    int lInt = l.Next(1, 39);

                    char letter;

                    switch (lInt)
                    {
                        case 1:
                            letter = 'a';
                            break;
                        case 2:
                            letter = 'b';
                            break;
                        case 3:
                            letter = 'c';
                            break;
                        case 4:
                            letter = 'd';
                            break;
                        case 5:
                            letter = 'e';
                            break;
                        case 6:
                            letter = 'f';
                            break;
                        case 7:
                            letter = 'g';
                            break;
                        case 8:
                            letter = 'h';
                            break;
                        case 9:
                            letter = 'i';
                            break;
                        case 10:
                            letter = 'j';
                            break;
                        case 11:
                            letter = 'k';
                            break;
                        case 12:
                            letter = 'l';
                            break;
                        case 13:
                            letter = 'm';
                            break;
                        case 14:
                            letter = 'n';
                            break;
                        case 15:
                            letter = 'o';
                            break;
                        case 16:
                            letter = 'p';
                            break;
                        case 17:
                            letter = 'q';
                            break;
                        case 18:
                            letter = 'r';
                            break;
                        case 19:
                            letter = 's';
                            break;
                        case 20:
                            letter = 't';
                            break;
                        case 21:
                            letter = 'u';
                            break;
                        case 22:
                            letter = 'v';
                            break;
                        case 23:
                            letter = 'w';
                            break;
                        case 24:
                            letter = 'x';
                            break;
                        case 25:
                            letter = 'y';
                            break;
                        case 26:
                            letter = 'z';
                            break;
                        case 27:
                            letter = '1';
                            break;
                        case 28:
                            letter = '2';
                            break;
                        case 29:
                            letter = '3';
                            break;
                        case 30:
                            letter = '4';
                            break;
                        case 31:
                            letter = '5';
                            break;
                        case 32:
                            letter = '6';
                            break;
                        case 33:
                            letter = '7';
                            break;
                        case 34:
                            letter = '8';
                            break;
                        case 35:
                            letter = '9';
                            break;
                        case 36:
                            letter = '0';
                            break;
                        case 37:
                            letter = '_';
                            break;
                        case 38:
                            letter = '-';
                            break;
                        default:
                            letter = '0';
                            break;

                    }

                    ranName.Append(letter);
                }

                String ranString = Convert.ToString(ranName);
                return ranString;
            }


            String ranDateModified()
            {
                String year = "2018";

                Random godRandom = new Random();

                String month;
                //Random rmonth = new Random();
                int ranMonth = godRandom.Next(1, 13);
                switch (ranMonth)
                {
                    case 1:
                        month = "01";
                        break;
                    case 2:
                        month = "02";
                        break;
                    case 3:
                        month = "03";
                        break;
                    case 4:
                        month = "04";
                        break;
                    case 5:
                        month = "05";
                        break;
                    case 6:
                        month = "06";
                        break;
                    case 7:
                        month = "07";
                        break;
                    case 8:
                        month = "08";
                        break;
                    case 9:
                        month = "09";
                        break;
                    default:
                        month = Convert.ToString(ranMonth);
                        break;
                }

                String day;
                //Random rday = new Random();
                int ranDay = godRandom.Next(1, 28);
                switch (ranDay)
                {
                    case 1:
                        day = "01";
                        break;
                    case 2:
                        day = "02";
                        break;
                    case 3:
                        day = "03";
                        break;
                    case 4:
                        day = "04";
                        break;
                    case 5:
                        day = "05";
                        break;
                    case 6:
                        day = "06";
                        break;
                    case 7:
                        day = "07";
                        break;
                    case 8:
                        day = "08";
                        break;
                    case 9:
                        day = "09";
                        break;
                    default:
                        day = Convert.ToString(ranDay);
                        break;
                }

                String hour;
                //Random rhour = new Random();
                int ranHour = godRandom.Next(0, 24);
                switch (ranHour)
                {
                    case 0:
                        hour = "00";
                        break;
                    case 1:
                        hour = "01";
                        break;
                    case 2:
                        hour = "02";
                        break;
                    case 3:
                        hour = "03";
                        break;
                    case 4:
                        hour = "04";
                        break;
                    case 5:
                        hour = "05";
                        break;
                    case 6:
                        hour = "06";
                        break;
                    case 7:
                        hour = "07";
                        break;
                    case 8:
                        hour = "08";
                        break;
                    case 9:
                        hour = "09";
                        break;
                    default:
                        hour = Convert.ToString(ranHour);
                        break;
                }

                String minute;
                //Random rminute = new Random();
                int ranMinute = godRandom.Next(0, 60);
                switch (ranMinute)
                {
                    case 0:
                        minute = "00";
                        break;
                    case 1:
                        minute = "01";
                        break;
                    case 2:
                        minute = "02";
                        break;
                    case 3:
                        minute = "03";
                        break;
                    case 4:
                        minute = "04";
                        break;
                    case 5:
                        minute = "05";
                        break;
                    case 6:
                        minute = "06";
                        break;
                    case 7:
                        minute = "07";
                        break;
                    case 8:
                        minute = "08";
                        break;
                    case 9:
                        minute = "09";
                        break;
                    default:
                        minute = Convert.ToString(ranMinute);
                        break;
                }

                String second;
                //Random rsecond = new Random();
                int ranSecond = godRandom.Next(0, 60);
                switch (ranSecond)
                {
                    case 0:
                        second = "00";
                        break;
                    case 1:
                        second = "01";
                        break;
                    case 2:
                        second = "02";
                        break;
                    case 3:
                        second = "03";
                        break;
                    case 4:
                        second = "04";
                        break;
                    case 5:
                        second = "05";
                        break;
                    case 6:
                        second = "06";
                        break;
                    case 7:
                        second = "07";
                        break;
                    case 8:
                        second = "08";
                        break;
                    case 9:
                        second = "09";
                        break;
                    default:
                        second = Convert.ToString(ranSecond);
                        break;
                }

                StringBuilder modDate = new StringBuilder();
                modDate.Append(year + ":");
                modDate.Append(month + ":");
                modDate.Append(day + " ");
                modDate.Append(hour + ":");
                modDate.Append(minute + ":");
                modDate.Append(second);

                String donModDate = Convert.ToString(modDate);
                return donModDate;
            }

            String ranDateCreated()
            {
                String year = "2017";

                Random godRandom = new Random();

                String month;
                //Random rmonth = new Random();
                int ranMonth = godRandom.Next(1, 13);
                switch (ranMonth)
                {
                    case 1:
                        month = "01";
                        break;
                    case 2:
                        month = "02";
                        break;
                    case 3:
                        month = "03";
                        break;
                    case 4:
                        month = "04";
                        break;
                    case 5:
                        month = "05";
                        break;
                    case 6:
                        month = "06";
                        break;
                    case 7:
                        month = "07";
                        break;
                    case 8:
                        month = "08";
                        break;
                    case 9:
                        month = "09";
                        break;
                    default:
                        month = Convert.ToString(ranMonth);
                        break;
                }

                String day;
                //Random rday = new Random();
                int ranDay = godRandom.Next(1, 28);
                switch (ranDay)
                {
                    case 1:
                        day = "01";
                        break;
                    case 2:
                        day = "02";
                        break;
                    case 3:
                        day = "03";
                        break;
                    case 4:
                        day = "04";
                        break;
                    case 5:
                        day = "05";
                        break;
                    case 6:
                        day = "06";
                        break;
                    case 7:
                        day = "07";
                        break;
                    case 8:
                        day = "08";
                        break;
                    case 9:
                        day = "09";
                        break;
                    default:
                        day = Convert.ToString(ranDay);
                        break;
                }

                String hour;
                //Random rhour = new Random();
                int ranHour = godRandom.Next(0, 24);
                switch (ranHour)
                {
                    case 0:
                        hour = "00";
                        break;
                    case 1:
                        hour = "01";
                        break;
                    case 2:
                        hour = "02";
                        break;
                    case 3:
                        hour = "03";
                        break;
                    case 4:
                        hour = "04";
                        break;
                    case 5:
                        hour = "05";
                        break;
                    case 6:
                        hour = "06";
                        break;
                    case 7:
                        hour = "07";
                        break;
                    case 8:
                        hour = "08";
                        break;
                    case 9:
                        hour = "09";
                        break;
                    default:
                        hour = Convert.ToString(ranHour);
                        break;
                }

                String minute;
                //Random rminute = new Random();
                int ranMinute = godRandom.Next(0, 60);
                switch (ranMinute)
                {
                    case 0:
                        minute = "00";
                        break;
                    case 1:
                        minute = "01";
                        break;
                    case 2:
                        minute = "02";
                        break;
                    case 3:
                        minute = "03";
                        break;
                    case 4:
                        minute = "04";
                        break;
                    case 5:
                        minute = "05";
                        break;
                    case 6:
                        minute = "06";
                        break;
                    case 7:
                        minute = "07";
                        break;
                    case 8:
                        minute = "08";
                        break;
                    case 9:
                        minute = "09";
                        break;
                    default:
                        minute = Convert.ToString(ranMinute);
                        break;
                }

                String second;
                //Random rsecond = new Random();
                int ranSecond = godRandom.Next(0, 60);
                switch (ranSecond)
                {
                    case 0:
                        second = "00";
                        break;
                    case 1:
                        second = "01";
                        break;
                    case 2:
                        second = "02";
                        break;
                    case 3:
                        second = "03";
                        break;
                    case 4:
                        second = "04";
                        break;
                    case 5:
                        second = "05";
                        break;
                    case 6:
                        second = "06";
                        break;
                    case 7:
                        second = "07";
                        break;
                    case 8:
                        second = "08";
                        break;
                    case 9:
                        second = "09";
                        break;
                    default:
                        second = Convert.ToString(ranSecond);
                        break;
                }

                StringBuilder modDate = new StringBuilder();
                modDate.Append(year + ":");
                modDate.Append(month + ":");
                modDate.Append(day + " ");
                modDate.Append(hour + ":");
                modDate.Append(minute + ":");
                modDate.Append(second);

                String donModDate = Convert.ToString(modDate);
                return donModDate;
            }

            Console.WriteLine("Please insert the directory folder here. Replace \\ (forward slash) with / (back slash)\n");
            String folder = Convert.ToString(Console.ReadLine());

            char[] delim = { '/' };

            String[] path = folder.Split(delim);

            StringBuilder actualPath = new StringBuilder();

            for (int i = 0; i < path.Length; i++)
            {
                if (i == path.Length - 1)
                {
                    actualPath.Append(path[i]);
                }
                else
                {
                    actualPath.Append(path[i]);
                    actualPath.Append('\\');
                }
            }

            //String pathPath = Convert.ToString(actualPath);
            Console.WriteLine(actualPath);

            Directory.SetCurrentDirectory(Convert.ToString(actualPath));

            //start working with files
            foreach (string file in Directory.EnumerateFiles(Convert.ToString(actualPath), "*.*"))
            {
                //code that changes the name and metadata

                //handle the extension
                String extension;

                char[] delim2 = { '.' };
                String fileString = Convert.ToString(file);
                String[] tok = fileString.Split(delim2);
                extension = tok[tok.Length - 1];

                //change the metadata
                Image mage = Image.FromFile(file);

                //modified date
                try
                {
                    PropertyItem modifiedDate = mage.GetPropertyItem(306);
                    modifiedDate.Value = System.Text.ASCIIEncoding.ASCII.GetBytes(ranDateModified());
                    mage.SetPropertyItem(modifiedDate);
                } catch
                {

                }
                

                String dateCreated = ranDateCreated();

                //original date
                try
                {
                    PropertyItem creationDate = mage.GetPropertyItem(36867);
                    creationDate.Value = System.Text.ASCIIEncoding.ASCII.GetBytes(dateCreated);
                    mage.SetPropertyItem(creationDate);
                } catch
                {

                }


                //digitized date
                try
                {
                    PropertyItem digitizedDate = mage.GetPropertyItem(36868);
                    digitizedDate.Value = System.Text.ASCIIEncoding.ASCII.GetBytes(dateCreated);
                    mage.SetPropertyItem(digitizedDate);
                }
                catch
                {

                }
                

                String newName = randomName();

                try
                {
                    mage.Save(newName + "." + extension);
                    mage.Dispose();
                    Console.WriteLine("File " + fileString + " successfully renamed to " + newName + "." + extension);
                    File.Delete(file);
                    Console.WriteLine("Deleted original file successfully.");
                }
                catch
                {
                    Console.WriteLine("File " + fileString + " could not be renamed.");
                }

            }
            Console.ReadKey();
        }
    }
}

