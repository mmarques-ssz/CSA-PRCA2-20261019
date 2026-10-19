using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTriangulos
{
    internal class Triangulo
    {
        private int lado1;
        private int lado2;
        private int lado3;
        private int classificao;

        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public Triangulo()
        {
            this.lado1 = 0;
            this.lado2 = 0;
            this.lado3 = 0;
        }

        public void setLado1(int lado1)
        {
            this.lado1 = lado1;
        }
        public void setLado2(int lado2)
        {
            this.lado2 = lado2;
        }
        public void setLado3(int lado3)
        {
            this.lado3 = lado3;
        }

        public int getLado1() 
        {
            return this.lado1;
        }
        public int getLado2()
        {
            return this.lado2;
        }
        public int getLado3()
        {
            return this.lado3;
        }
        public int getClassificacao()
        {
            return this.classificao;
        }
        public void classificar()
        {
            if (this.lado1 + this.lado2 > this.lado3 &&
                this.lado1 + this.lado3 > this.lado2 &&
                this.lado2 + this.lado3 > this.lado1)
            {
                if (this.lado1 == this.lado2 && this.lado1 == this.lado3)
                {
                    this.classificao = 1;
                }
                else
                {
                    if (this.lado1 == this.lado2 ||
                        this.lado1 == this.lado3 ||
                        this.lado2 == this.lado3)
                    {
                        this.classificao = 2;
                    }
                    else
                    {
                        this.classificao = 3;
                    }
                }
            }
            else
            {
                this.classificao = 0;
            }
        }
    }

}
