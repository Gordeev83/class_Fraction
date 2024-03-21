namespace Class_Fraction
{
    public class FractionBase
    {

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Fraction other = (Fraction)obj;
            return this.numerator * other.denominator == this.denominator * other.numerator;
        }

        public override int Get_HashCode()
        {
            return numerator ^ denominator;
        }
        public override int Get_HashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }
    }
}