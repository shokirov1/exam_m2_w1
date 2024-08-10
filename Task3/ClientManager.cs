using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ClientManager<T> where T : Client
    {
        List<T> list = new List<T>();

        public void Creat(T item)
        {
            try
            {
                if(item!=null)
                {
                    list.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<T> Read()
        {
            try
            {
                if(list!=null)
                {
                    return list;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public void Update(int clientId)
        {
            try
            {
                var checkForUpdate = list.FirstOrDefault(x => x.ClientId == clientId);
                if(checkForUpdate != null)
                {
                    list.Remove(checkForUpdate);
                    Client client = new Client();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool Delete(int clientId)
        {
            try
            {
                var checkDelete = list.FirstOrDefault(x => x.ClientId == clientId);
                if(checkDelete != null)
                {
                    list.Remove(checkDelete);
                    return true;
                }
                else
                {
                    return false;
                }    
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
