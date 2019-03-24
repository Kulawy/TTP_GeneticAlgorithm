using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingThiefProblemSolver.Data;
using TravellingThiefProblemSolver.Model;

namespace TravellingThiefProblemSolver.Loaders
{
    public class DataParser
    {
        //private readonly FileStream _fileStream;
        //public DataParser(FileStream fileStream)
        //{
        //    _fileStream = fileStream;
        //}

        DataContainer _container;

        public DataParser()
        {
            DataContainer.Clear();
            _container = DataContainer.Instance;
        }

        public void ParseDataFromFileStream(FileStream fileStream)
        {
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                streamReader.ReadLine();
                streamReader.ReadLine();
                FitDimension(streamReader.ReadLine());
                FitNumberOfItems(streamReader.ReadLine());
                FitCapacity(streamReader.ReadLine());
                FitMinSpeed(streamReader.ReadLine());
                FitMaxSpeed(streamReader.ReadLine());
                FitRentingRatio(streamReader.ReadLine());
                streamReader.ReadLine();
                streamReader.ReadLine();
                
                for(int i = 0; i< _container.Dimension; i++)
                {
                    FitCity(streamReader.ReadLine());
                }
                streamReader.ReadLine();
                for (int i = 0; i < _container.NumberOfItems; i++)
                {
                      FitItem(streamReader.ReadLine());
                }

                //string line;
                //while ((line = streamReader.ReadLine()) != null)
                //{

                //}
            }

        }

        private void FitCity(string text)
        {
            string sep = "\t";
            string[] splitContent = text.Split(sep.ToCharArray());
            _container._Cities.Add(new Model.City(Int32.Parse(splitContent[0]), Double.Parse(splitContent[1].Replace(".", ",")), Double.Parse(splitContent[2].Replace(".", ","))));
        }

        private void FitItem(string text)
        {
            //string[] splited = text.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            if (text == null)
                return;
            string[] splitContent = text.Split(new char[0]);
            Item newItem = new Item(Int32.Parse(splitContent[0]), Int32.Parse(splitContent[1]), Int32.Parse(splitContent[2]), Int32.Parse(splitContent[3]));
            _container._Items.Add(newItem);
            _container._Cities.Find(c => c.CityId == newItem.AssignedNodeNumber).ItemsInCity.Add(newItem);
            newItem = null;
        }
        
        private void FitDimension(string text)
        {
            if (text.ToUpper().Contains("dimension".ToUpper()))
            {
                string[] words = text.Trim().Split(':');
                _container.Dimension = Int32.Parse(words[1]);
            }

        }

        private void FitNumberOfItems(string text)
        {
            if (text.ToUpper().Contains("NUMBER OF ITEMS".ToUpper()))
            {
                string[] words = text.Trim().Split(':');
                _container.NumberOfItems = Int32.Parse(words[1]);
            }
        }

        private void FitCapacity(string text)
        {
            if (text.ToUpper().Contains("CAPACITY".ToUpper()))
            {
                string[] words = text.Trim().Split(':');
                _container.Capacity = Int32.Parse(words[1]);
            }
        }

        private void FitMinSpeed(string text)
        {
            if (text.ToUpper().Contains("MIN SPEED".ToUpper()))
            {
                string[] words = text.Trim().Split(':');
                _container.MinSpeed = Double.Parse(words[1].Replace('.',','));
            }
        }

        private void FitMaxSpeed(string text)
        {
            if (text.ToUpper().Contains("MAX SPEED".ToUpper()))
            {
                string[] words = text.Trim().Split(':');
                _container.MaxSpeed = Double.Parse(words[1].Replace('.', ','));
            }
        }

        private void FitRentingRatio(string text)
        {
            if (text.ToUpper().Contains("RENTING RATIO".ToUpper()))
            {
                string[] words = text.Trim().Split(':');
                _container.RentingRatio = Double.Parse(words[1].Replace('.', ','));
            }
        }

        





    }
}
