namespace CoffeeShop.File
{
    public class FileIO
    {

        //save to file
        public static void SaveToFile(string fileName, string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(data);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}