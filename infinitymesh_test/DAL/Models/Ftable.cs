//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace infinitymesh_test.DAL.Models
//    {
//    public class Ftable<T> where T : class, IEntity
//        {
//           public List<T> data { get; set; }

//           public Ftable()
//            {
//              data = new List<T>();
//            }

//            public List<T> getAll()
//               {
//                    return data;
//               }

//            public T getElementByID(int id)
//               {
//                   foreach (T row in data)
//                       {
//                        if (row.Id == id)
//                            {
//                               return row;
//                             }    

//                       }    
//                   return null;
//               }

//            public void Insert(T obj)
//                {
//                    data.Add(obj);
//                }

//            public void Update(T obj)
//                {
//                     T old = getElementByID(obj.Id);
//                     data.Remove(old);
//                     data.Add(obj);
//                }

//            public void Delete(T obj)
//                {
//                   data.Remove(obj);
//                }
//        }
//    }