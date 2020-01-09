using System;
using operations;

namespace Cube
{
    public interface ICube
    {
        public dynamic Cubed(dynamic a);
    }
    public class Cube : ICube
    {
        public dynamic result;

        public dynamic Cubed(dynamic a)
        {
            result = Cube.Cubed(a);
            return result;
        }
    }
}