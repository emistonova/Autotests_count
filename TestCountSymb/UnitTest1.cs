namespace TestCountSymb
{
    [TestClass]
    public class UnitTest1
    {
        // классы эквиваленотости
        // 0) пуста€ строка из пробелов
        // 1) повтор€ющ. сиволы, повтор€ющ. буквы, повтор€ющ. числа 
        // 2) повтор€ющ. символы, повтор€ющ. буквы, без чисел
        // 3) повтор€ющ. символы без букв, без чисел
        // 4) буквы, без символов, без чисел 
        // 5) повтор€ющ числа
        // 6) повтор€ющ. символы, повтор€ющ. числа
        // 7) неповтор€юшиес€ символы, буквы, числа 

        // тестируем нулевую (пустую строку) 
        Count.Count count0 = new Count.Count("      ");
        [TestMethod] //  
        public void AllTest0()
        {
            int i0 = count0.Symbols();
            int i00 = count0.Letters();
            int i000 = count0.Numbers();
            Assert.AreEqual(1, i0);
            Assert.AreEqual(0, i00);
            Assert.AreEqual(0, i000);
        }

        //
        // 1 , содержит: повтор€ющ. буквы, повтор€ющ. символы, в тч пробел, повтор. числа
        Count.Count count = new Count.Count("marchmarch 5566789##@@");
       
        [TestMethod] 
        public void ALLTest1()
        {
            int i1 = count.Symbols();
            int i2 = count.Letters();
            int i3 = count.Numbers();
            Assert.AreEqual(13, i1);
            Assert.AreEqual(5, i2);
            Assert.AreEqual(5, i3);
        }

        //  *****************************************
        // 2 строку, содержит повтор€ющиес€ буквы, повтор€ющ символы, без чисел  
        Count.Count count2 = new Count.Count("DIRDIRсимвол@@#$$$");
        [TestMethod]
        public void AllTest2()
        {
           int i4 = count2.Symbols();
           int i5 = count2.Letters();
           int i6 = count2.Numbers();
           Assert.AreEqual(12, i4);
           Assert.AreEqual(9, i5);
           Assert.AreEqual(0, i6);
        }
        // **************************
        // 3 строку содержит только повтор символы, без букв, без чисел 
        Count.Count count3 = new Count.Count("&&&%%%$$#@ ***");
        
        [TestMethod]
        public void AllTest3()
        {
            int i7 = count3.Symbols();
            int i8 = count3.Letters();
            int i9 = count3.Numbers();
            Assert.AreEqual(7, i7);
            Assert.AreEqual(0, i8);
            Assert.AreEqual(0, i9);
         }

        // **********************
        // 4 строку, содержит без символов, только повтор€ющиес€ буквы, без чисел 
        Count.Count count4 = new Count.Count("aaaaaddddrrrrqqqp");
        [TestMethod]
        public void AllTest4()
        {
            int i10 = count4.Symbols();
            int i11 = count4.Letters();
            int i12 = count4.Numbers();
            Assert.AreEqual(5, i10);
            Assert.AreEqual(5, i11);
            Assert.AreEqual(0, i12);
        }
        // *****************************
        // 5 строку содержит только повтор€ющ числа 
        Count.Count count5 = new Count.Count("12345123456");
        [TestMethod]

        public void AllTest5()
        {
            int i13 = count5.Symbols();
            int i14 = count5.Letters();
            int i15 = count5.Numbers();
            Assert.AreEqual(6,i13);
            Assert.AreEqual(0,i14);
            Assert.AreEqual(6, i15);
        }
        //***********************
        // 6 строка, содержит только повтор символы, повтор числа
        Count.Count count6 = new Count.Count("333   #555#");
        [TestMethod]
        public void AllTest6()
        {
            int i16= count6.Symbols();
            int i17 = count6.Letters();
            int i18 = count6.Numbers();
            Assert.AreEqual(4, i16);
            Assert.AreEqual(0, i17);
            Assert.AreEqual(2, i18);
        }
        //***********************************************************
        // 7а€: неповтор€ющиес€ символы, буквы, числа 
        Count.Count count7= new Count.Count("ABCабвг98765 ? ;!");
        [TestMethod]

        public void AllTest7()
        {
            int i = count7.Symbols();
            int b = count7.Letters();
            int c = count7.Numbers();
            Assert.AreEqual(16,i);
            Assert.AreEqual(7, b);
            Assert.AreEqual(5, c);
        }
    }
}