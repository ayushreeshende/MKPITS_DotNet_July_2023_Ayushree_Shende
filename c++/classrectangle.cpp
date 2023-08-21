#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length,breadth;
area()
	{
 float a=length*breadth;
return a;		
}
float perimeter()
{
float perimeter=2*(length+breadth);
return perimeter;
}
};
int main()
{
	float result;
	rectangle r1;
	cout<<"enter length and breadth";
	cin>>r1.length>>r1.breadth;
	result=r1. area();
	cout<<"area is="<<result;
	result=r1.perimeter();
	cout<<"perimeter is="<<result;
	return 0;
}

