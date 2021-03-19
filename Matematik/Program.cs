using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            //DortIslem classındaki Topla hesaplamasını çağırıyoruz.

            dortIslem.Topla(5,6);

            dortIslem.Topla(6,9);
        }
    }
}
