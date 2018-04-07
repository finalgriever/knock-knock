using KnockKnock.Exceptions;

namespace KnockKnock.Models
{
    public class Triangle
    {
        public const string EQUILATERAL = "Equilateral";
        public const string SCALENE = "Scalene";
        public const string ISOSCELES = "Isosceles";

        private int _firstSide;

        private int _secondSide;

        private int _thirdSide;

        private void Validate()
        {
            var valid = true;
            valid &= _firstSide > 0;
            valid &= _secondSide > 0;
            valid &= _thirdSide > 0;
            valid &= (_firstSide + _secondSide) > _thirdSide;
            valid &= (_thirdSide + _firstSide) > _secondSide;
            valid &= (_secondSide + _thirdSide) > _firstSide;
            if(!valid)
            {
                throw new DomainException("Attempted to create an impossible triangle");
            }
        }

        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
            Validate();
        }

        public string Type
        {
            get
            {
                if (_firstSide == _secondSide && _firstSide == _thirdSide)
                {
                    return EQUILATERAL;
                }
                if (_firstSide == _secondSide || _secondSide == _thirdSide || _thirdSide == _secondSide)
                {
                    return ISOSCELES;
                }
                return SCALENE;
            }
        }
    }
}