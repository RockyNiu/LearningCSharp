#include <stdio.h>

double getCylinderVolumn(double r, double h)
{
	double area = 3.1416*r*r;
	double volume = area * h;
	return volume;
}

int main()
{
	double result = getCylinderVolumn(10, 100);
	printf("Volumn=%f\n", result);
	return 0;
}