using System;

namespace VectorTest
{
    public class Vector
    {
        private double[] _components;

        public Vector(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность вектора должна быть > 0.");
            }

            _components = new double[n];
        }

        public Vector(Vector vector): this(vector._components) { }

        public Vector(double[] array)
        {
            if (array.Length <= 0)
            {
                throw new ArgumentException("Размерность вектора должна быть > 0.");
            }

            _components = new double[array.Length]; 
            array.CopyTo(_components, 0);
        }

        public Vector(int n, double[] array)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность вектора должна быть > 0.");
            }
            
            _components = new double[n];
            Array.Copy(array, 0, _components, 0, Math.Min(n, array.Length));
        }

        public int Length
        {
            get
            {
                return _components.Length;
            }
        }

        public override string ToString()
        {
            return "{ " + string.Join(", ", _components) + " }";
        }

        public Vector GetSum(Vector vector2)
        {
            var minSize = Math.Min(Length, vector2.Length);
            
            if (Length < vector2.Length)
            {
                Array.Resize(ref _components, vector2.Length);
                Array.Copy(vector2._components, minSize, _components, minSize, vector2.Length - minSize);
            }
            
            for (var i = 0; i < minSize; i++)
            {
                _components[i] += vector2._components[i];
            }

            return this;
        }

        public Vector GetDifference(Vector vector2)
        {
            var minSize = Math.Min(Length, vector2.Length);
            
            if (Length < vector2.Length)
            {
                Array.Resize(ref _components, vector2.Length);
                Array.Copy(new Vector(vector2).Reverse()._components, minSize, _components, minSize, vector2.Length - minSize);
            }

            for (var i = 0; i < minSize; i++)
            {
                _components[i] -= vector2._components[i];
            }

            return this;
        }

        public Vector MultiplyByScalar(double scalar)
        {
            for (var i = 0; i < Length; i++)
            {
                _components[i] *= scalar;
            }

            return this;
        }

        public Vector Reverse()
        {
            return MultiplyByScalar(-1);
        }

        public double GetComponent(int index)
        {
            return _components[index];
        }

        public void SetComponent(int index, double newComponent)
        {
            _components[index] = newComponent;
        }

        public static Vector GetSum(Vector vector1, Vector vector2)
        {
            return new Vector(vector1).GetSum(vector2);
        }

        public static Vector GetDifference(Vector vector1, Vector vector2)
        {
            return new Vector(vector1).GetDifference(vector2);
        }

        public static double GetScalarMultiplication(Vector vector1, Vector vector2)
        {
            double sum = 0;
            int minSize = Math.Min(vector1.Length, vector2.Length);

            for (int i = 0; i < minSize; i++)
            {
                sum += vector1._components[i] * vector2._components[i];
            }

            return sum;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != this.GetType())
            {
                return false;
            }

            var vector = (Vector)obj;

            if (vector.Length != Length)
            {
                return false;
            }
            else
            {
                for (var i = 0; i < Length; i++)
                {
                    if (vector.GetComponent(i) != GetComponent(i))
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public override int GetHashCode()
        {
            const int prime = 13;
            var hash = 1;

            foreach (var component in _components)
            {
                hash = prime * hash + component.GetHashCode();
            }

            return hash;
        }
    }
}

