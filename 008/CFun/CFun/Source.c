# include <stdio.h>

double Add(double a, double b)

{
	return a + b;
}

int main()
{
	double x = 3;
	double y = 4;
	double result = Add(x, y);
	printf("%.1f+%.1f=%.1f", x, y, result);
}