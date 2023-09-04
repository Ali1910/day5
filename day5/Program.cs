using System;
using System.Security.AccessControl;

namespace day5
{
    #region inheritance , method hide , virtual , override
    //class parent
    //{
    //    public int x { get; set; }
    //    public virtual void show() // virtual class
    //    {
    //        Console.WriteLine($"x={x}");

    //    }
    //    public parent(int x)
    //    {
    //        this.x= x;
    //    }
    //    public parent()
    //    {

    //    }
    //}
    //class child:parent {
    //    public int y { get; set; }
    //    // public new int x { get; set; } //variable hidden

    //    //public child(int x, int y)//mistake because we created parameter constracor for parent
    //    //{
    //    //    this.x = x;
    //    //    this.y = y;
    //    //}

    //    public child(int x ,int y):base(x) //chaining 
    //    {
    //        this.y= y;

    //    }
    //    public child()
    //    {

    //    }
    //    //public  new void show()//method hidden
    //    //{
    //    //    base.show();// extend from parent base is keyword refer to parent class
    //    //    Console.WriteLine($"y={y}");


    //    //    //Console.WriteLine($"x={x} , y={y}");

    //    //}
    //    public virtual void show()
    //    {
    //        base.show();
    //        Console.WriteLine($"y={y}");
    //    }
    //}
    //class child2:parent { }

    //class test
    //{
    //    public void display(parent p)
    //    {
    //        p.show();// بتاعت ال parent
    //    }    
    //}

    //class subchild : child
    //{
    //    public int z { get; set; }

    //    //public override void show()
    //    //{
    //    //    base.show();

    //    //    Console.WriteLine($"z={z}");
    //    //}

    //    //public new void show() //hide child show  
    //    //{
    //    //    base.show();

    //    //    Console.WriteLine($"z={z}");
    //    //}
    //}
    #endregion
    #region abstract 

    //abstract class parent {
    //    public int x { get; set; }
    //    //public virtual void show() // may be override or not 
    //    //{
    //    //    Console.WriteLine($"x={x}");
    //    //}

    //    public abstract void show();// must be override 
    //}
    //class child : parent
    //{
    //    public override void show()
    //    {
    //        Console.WriteLine($"x={x}");
    //    }
    //}
    #endregion

    #region sealed
    //sealed class test
    //{

    //}
    ////class t2 : test//xxxxxxxxxxxxx sealed class
    ////{

    ////}
    //class parent
    //{
    //    public int x { get; set; }

    //    public virtual void show()
    //    {
    //        Console.WriteLine($"x={x}");
    //    }
    //}

    //class child : parent 
    //{
    //    public int y { get; set; }
    //    public override sealed void show()
    //    {
    //        Console.WriteLine($"x={x},y={y}");

    //    } 
    //}
    //class subChild : child
    //{
    //    public int z { get; set; }
    //    public new void show()
    //    {
    //        Console.WriteLine($"x={x},y={y},z={z}");

    //    }
    //}
    #endregion

    #region static
    class student
    {
        public int id { get; set; }
        public String name { get; set; }
        public int age { get; set; }

        public static int count;// shared variable 
        public student(int id,string name , int age )

        {
            this.id = id;   
            this.name = name;
            this.age = age;
            count++;
        }

        public student()
        {
            count++;
        }

        public string getString()
        {
            return $"{id}--{name}\t\t{age} years old";
        }
        static student()// static constractor
        {
            count = 0;
        }
    }

    class calc
    {
        public static int sum(int x, int y)// called with class no need for obiect but note that doesn't deal of local variable
        {
            return x+y ;
        }
    }
    static class t // static class
    {
        public static int x { get; set; }
    }


    #endregion

    #region lab
    abstract class question
    {
        public  int  id { get; set; }
        public string body { get; set; }
        public int mark { get; set; }

        public abstract void show();
    }

    class mcq : question
    {
        public mcq(int id ,string body ,int mark,int NumOfAnswers)
        {
            this.id = id;
            this.body = body;
            this.mark = mark;

            answers=new string[NumOfAnswers];
                    
            
        }
        public  string[] answers  { get; set; }
        public override void show()
        {

            Console.WriteLine($"{id}--{body}\t\t{mark}");
            for(int i=0;i<answers.Length; i++)
            {
                Console.WriteLine(answers[i]);
            }
            
        }
    }
    class torf : question
    {
        public torf(int id, string body, int mark)
        {
            this.id = id;
            this.body = body;
            this.mark = mark;
        }
        public override void show()
        {

            Console.WriteLine($"{id}--{body}\t\t{mark}\n true \\ flase");
            

        }
    }
    class test : question
    {
        public int numberOfmcq { get; set; }
        public int numOfTORF { get; set; }
        public mcq[] mcqs { get; set; }
        public torf[] TorFS { get; set; }
        public test(int numberOfmcq,int numOfTORF)
        {
            mcqs= new mcq[numberOfmcq];
            TorFS = new torf[numOfTORF];
            
            
            
        }

        public override void show()
        {
            
            for (int i = 0; i < mcqs.Length; i++)
            {
                Console.WriteLine($"{mcqs[i].id}--{mcqs[i].body}\t\t{mcqs[i].mark}");

                for (int j = 0; j < mcqs[i].answers.Length; j++)
                {
                    Console.WriteLine(mcqs[i].answers[j]);
                }
            }
            for (int i = 0; i < TorFS.Length; i++)
            {
                Console.WriteLine($"{TorFS[i].id}--{TorFS[i].body}\t\t{TorFS[i].mark}\n true \\ flase");

            }

        }
    }
    #endregion
    class program
    {
        static void Main()
        {
            #region inheritance , method hide , virtual , override
            //child c= new child();
            //c.x = 5;
            //c.y = 5;
            //c.show();

            //child c = new child(2,3);
            //c.show();

            //parent p = new parent();
            //p.show();// show of parent because it's loaded in memory show of child is not in the memory

            //parent p = new child(1,2);// ينفع لانه بيشاور على حاجة من نوعه لكن بيشوف اجزء بتاعه بس 
            //p.show();// بتاعت ال parent 

            //test t = new test();
            //t.display(new child(1, 2));
            //t.display(new child2());
            //t.display(new parent());

            // child c= new parent();//xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx لازم يشاور على حاجة من نوعه
            //parent p = new child(1,2);
            //p.show();//  بتاعت ال child  نتيجة اني عامل virtual function

            //parent p1= new child2();
            //p1.show();// بتاعت ال parent  لان مفيش override in child2

            //parent p2 = new parent();
            //p2.show();// بتاعت ال parent 

            //parent p =new child();
            //p.show();// بتاعت ال child extend load in memory لانها  اخر 

            //parent p1 = new subchild();
            //p1.show();// بتاعت ال subchild extend load in memory لانها  اخر 

            //parent p2 = new subchild();
            //p2.show();// بتاعت ال child  لاني وقفت ال  virtual  باستخدام  new 

            //parent p3 = new subchild();
            //p3.show();//  error beacuse child now doesn't extend virtuality 

            #endregion

            #region abstract
            // parent p=new parent();// xxxxxxxxxxxxxx abstract class
            #endregion
            #region static
            //student s=new student(1,"ali",22);
            //student s1 = new student(5,"mona",20);

            //Console.WriteLine(student.count);

            //student s2 = new student(5, "reda", 22);
            //Console.WriteLine(student.count);

            //calc.sum(4,6); // called without object 
            #endregion
            #region lab
            //mcq quetion
            //Console.WriteLine("enter question id ");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter  question ");
            //string body = Console.ReadLine();
            //Console.WriteLine("enter  question mark ");
            //int mark = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter number of answers  ");
            //int numOfAnswers = int.Parse(Console.ReadLine());
            //mcq que = new mcq(id, body, mark, numOfAnswers);
            //string[] answers = new string[numOfAnswers];
            //for (int i = 0; i < answers.Length; i++)
            //{
            //    Console.WriteLine($"enter answer number {i + 1}");
            //    answers[i] = Console.ReadLine();
            //}
            //que.answers = answers;

            //que.show();

            //torf question
            //Console.WriteLine("enter question id ");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter  question ");
            //string body = Console.ReadLine();
            //Console.WriteLine("enter  question mark ");
            //int mark = int.Parse(Console.ReadLine());
            //question torf = new torf(id,body,mark);
            //torf.show();

            // test 
            Console.WriteLine("enter number of mcq questions");
            int x= int.Parse( Console.ReadLine() );
            Console.WriteLine("enter number of TorF questions");
            int y = int.Parse(Console.ReadLine());

            test t = new test(x,y);
            for(int i = 0; i < x; i++)

            {
                Console.WriteLine("enter question id ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter  question ");
                string body = Console.ReadLine();
                Console.WriteLine("enter  question mark ");
                int mark = int.Parse(Console.ReadLine());
                Console.WriteLine("enter number of answers  ");
                int numOfAnswers = int.Parse(Console.ReadLine());
                t.mcqs[i] = new mcq(id,body,mark,numOfAnswers);
                int j ;
                for (j=0; j < numOfAnswers; j++)
                {
                    Console.WriteLine($"enter answer number {j + 1}");
                    t.mcqs[i].answers[j] = Console.ReadLine();
                  
                }
              
            }
            for(int i = 0; i < y;i++) {
                Console.WriteLine("enter question id ");
                int id1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter  question ");
                string body1 = Console.ReadLine();
                Console.WriteLine("enter  question mark ");
                int mark1 = int.Parse(Console.ReadLine());
                t.TorFS[i] = new torf(id1, body1, mark1);
            }
            t.show();








            #endregion


        }
    }
}