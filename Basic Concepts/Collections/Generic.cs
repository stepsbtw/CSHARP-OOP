using System;
using System.Collections.Generic;

namespace Generic_{
    // CREATING MY OWN GENERIC COLLECTION!
    public class PacoList<T>{
        private List<T> items = new List<T>();
        public void Add(T x){
            items.Add(x);
        }
        public void Remove(T x){
            items.Remove(x);
        }
        public List<T> GetAll(){
            return items;
        }
    }

    public class PacoDynamicArray<T>{
        private T[] paco;
        private int i;

        public PacoDynamicArray(){
            // default size is 5
            paco = new T[5];
            i=0;
        }
        public void Add(T x){
            // need to resize!
            if(i == paco.length){
                ResizePaco();
            }
            paco[i] = x;
            i++;
        }
        public void Remove(T x){
            if(paco.Length == 0){
                return;
            }

        }
        public T[] GetAll(){
            // NEED TO COPY THE ARRAY
            // OR ELSE I GIVE A REFERENCE TO MY INTERNAL ARRAY
            // return paco;
            T[] newPaco = new T[i];
            Array.Copy(paco,newPaco,i);
            return newPaco;
        }
        public void ResizePaco(){
            // im doubling the size and copying it to the new one.
            T[] newPaco = new T[i*2];
            Array.Copy(paco,newPaco,i);
            paco = newPaco;
            Console.WriteLine("RESIZE!"); // DEBUG
        }


    }

    public class Program{
        public static void Main(string[] args){
            PacoList<string> listPaco = new Paco<string>();
            listPaco.Add("Hello");
            listPaco.Add("World");
            foreach(string s in listPaco){
                Console.WriteLine(s);
            }

            PacoDynamicArray<int> dynamicPaco = new PacoDynamicArray<int>();
            for(int i = 0; i < 20; i++){
                dynamicPaco.Add(i);
                // SHOULD SHOW 3 TIMES THE "RESIZE" MESSAGE.
            }
        }
    }
}