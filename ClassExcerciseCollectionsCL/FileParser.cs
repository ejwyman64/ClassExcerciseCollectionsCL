using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassExcerciseCollectionsCL
{
    class FileParser : IFileParser
    {
        public string[] Read(string path)
        {

            //declare variables
            int arraySize = 0;
            string[] array;

            //stream reader without "using"
            var streamReader = new StreamReader(path);

            //parse array size into an int
            arraySize = int.Parse(streamReader.ReadLine());

            //initialize array with the arraySize
            array = new string[arraySize];

            //for loop to iterate over the length of the array
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = streamReader.ReadLine();
            }

            //close reader
            streamReader.Close();
            //dispose of reader
            streamReader.Dispose();

            return array;

        }
    }
}
