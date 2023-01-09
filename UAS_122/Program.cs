using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UAS_122
{

    class Node
    {
        public int number;
        public string name;
        public Node next;
    }

    class Queue
    {
        Node asrul, rul;

        public Queue()
        {
            asrul = null;
            rul = null;
        }

        public void addNumb()
        {
            int no;
            string nm;
            Console.WriteLine("Enter a number: ");
            no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.number = no;
            newnode.name = nm;
            if (asrul == null || (no <= asrul.number))
            {
                if ((asrul != null) && (no == asrul.number))
                {
                    Console.WriteLine("Duplicate Number is not allowwed");
                    return;
                }

                newnode.next = asrul;
                newnode.next = rul;
                asrul = rul = newnode;
                return;
            }

            while ((asrul != null) && (no <= asrul.number)) ;
            {
                if (no == asrul.number)
                {
                    Console.WriteLine(" Duplicate Nuumber is not allow ");
                    return;
                }
                asrul.next = newnode;
                newnode = asrul;
                return;
            }
        }
        public bool ListEmpty()
        {
            if (asrul == null)
                return true;
            else
                return false;
        }

        public void delNumb()
        {
            Node curr;
            curr = asrul;
            Console.WriteLine("the deleted number is: " + asrul.number + asrul.name);
            asrul = asrul.next;
        }

        public void displayNumb()
        {
            if (ListEmpty())
            {
                Console.WriteLine(" list empty. ");
            }
            else
            {
                Console.WriteLine("the number is the list are: ");
                Node currNode;
                for (currNode = asrul; currNode != null; currNode = currNode.next)
                    Console.WriteLine(" -" + currNode.number + currNode.name);
                Console.WriteLine();
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            while (true)
            {
                try
                {
                    Console.WriteLine("-----menu----");
                    Console.WriteLine("a. insert number");
                    Console.WriteLine("b. delete number");
                    Console.WriteLine("c. display");
                    Console.WriteLine("d. exit");
                    Console.Write(" choice a-d : ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case 'a':
                            {
                                q.addNumb();
                            }
                            break;
                        case 'b':
                            {
                                if (q.ListEmpty())
                                {
                                    Console.WriteLine("list empty. ");
                                    break;
                                }
                                q.delNumb();
                            }
                            break;
                        case 'c':
                            {
                                q.displayNumb();
                            }
                            break;
                        case 'd':
                            return;
                        default:
                            {
                                Console.WriteLine("\n invalid option ");
                                break;
                            }
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("\n Check again! . ");
                }
            }
        }
    }

}

//JAWABAN ESSAY
// 2. berdasrkan studi kasus di atas ada beberapa algoritma yang saya gunakan adalah class node dan queue 
// 3. Stack atau Tumpukan adalah suatu struktur data yang terbentuk dari barisan hingga yang terurut dari satuan data. Pada Stack, penambahan dan penghapusan elemennya hanya dapat
//    dilakukan pada satu posisi, yaitu posisi akhir stack. Posisi ini disebut Puncak atau Top dari stack.
// 4. Algoritma Queue merupakan struktur data dimana satu data dapat ditambahkan di akhir disebut "FRONT" dan data dihapus dari yang paliang terakhir disebut "REAR"
// 5. a. kedalaman yang dimiliki struktur adalah 5
////  b. 1. membaca gambar menggunakan metode postorder mulai dari kanan
////     2. cara membaca  gambar di atas dengan menggunakan metode inorder adalah membaca di mualai dari ibu atau angka yang paling besar kemuadian di lanjut dengan anak kanan atau
////     sebla kanan angka sampe selesai kemudian lanjut ke sebla kiri angka apabila kiri angka memiliki anak kanan atau bisa disebut sebla kanan angka makan kita dahulukan anak kanan
////     kemudia lanjut ke anak kiri sampe selesai