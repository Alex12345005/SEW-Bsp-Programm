using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp_Programm
{
    class SLinkList

    {

        private int data;

        private SLinkList next;



        public SLinkList()

        {

            data = 0;

            next = null;

        }



        public SLinkList(int value)

        {

            data = value;

            next = null;

        }





        public SLinkList InsertNext(int value)

        {

            SLinkList node = new SLinkList(value);

            if (this.next == null)

            {

                // Easy to handle

                node.next = null; // already set in constructor

                this.next = node;

            }

            else

            {

                // Insert in the middle

                SLinkList temp = this.next;

                node.next = temp;

                this.next = node;

            }

            return node;

        }



        public int DeleteNext()

        {

            if (next == null)

                return 0;



            SLinkList node = this.next;

            this.next = this.next.next;  // can be NULL here

            node = null;

            return 1;

        }



        public void Traverse(SLinkList node)

        {

            if (node == null)

                node = this;

            System.Console.WriteLine("\n\ncontinue and delete\n\n");



            while (node != null)

            {

                System.Console.WriteLine(node.data);

                node = node.next;

            }

        }



    }



    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Bsp.- Programm");
            Console.WriteLine("_______________________________________");


            SLinkList node1 = new SLinkList(1);

            SLinkList node2 = node1.InsertNext(2);

            SLinkList node3 = node2.InsertNext(3);

            SLinkList node4 = node3.InsertNext(4);

            SLinkList node5 = node4.InsertNext(5);

            SLinkList node6 = node5.InsertNext(6);

            SLinkList node7 = node6.InsertNext(7);

            SLinkList node8 = node7.InsertNext(8);

            SLinkList node9 = node8.InsertNext(9);

            SLinkList node10 = node9.InsertNext(10);

            SLinkList node11 = node10.InsertNext(11);

            SLinkList node12 = node11.InsertNext(12);

            SLinkList node13 = node12.InsertNext(13);

            SLinkList node14 = node13.InsertNext(14);

            SLinkList node15 = node14.InsertNext(15);

            SLinkList node16 = node15.InsertNext(16);

            SLinkList node17 = node16.InsertNext(17);

            SLinkList node18 = node17.InsertNext(18);

            SLinkList node19 = node18.InsertNext(19);

            SLinkList node20 = node19.InsertNext(20);

            Console.WriteLine("______________________________________________");

            node1.Traverse(null);

            node3.DeleteNext(); // delete the node "4"

            Console.WriteLine("______________________________________________");

            node2.Traverse(null);

            node8.DeleteNext(); //delete the node "9"

            Console.WriteLine("______________________________________________");

            node3.Traverse(null);

            node19.DeleteNext();

            node13.DeleteNext();

            Console.WriteLine("______________________________________________");

            node11.Traverse(null);

            node16.DeleteNext();



        }

    }


}