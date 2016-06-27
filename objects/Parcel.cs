namespace ParcelProject.Objects
{
  public class Parcel
  {
    private double _length;
    private double _width;
    private double _weight;
    private double _smallPackageRate = 1; //dollars per pound
    private double _largePackageRate = 5;
    private double _smallPackageMaxVolume = 400;

    public Parcel(double length, double width, double weight)
    {
      _length = length;
      _width = width;
      _weight = weight;
    }

    public double Volume()
    {
      return _length * _width;
    }

    public bool IsSmallPackage()
    {
      if (Volume() <= _smallPackageMaxVolume) {
        return true;
      } else {
        return false;
      }
    }


    public double CostToShip()
    {
      if (IsSmallPackage()) {
        return _smallPackageRate * _weight;
      } else {
        return _largePackageRate * _weight;
      }
    }
  }
}
