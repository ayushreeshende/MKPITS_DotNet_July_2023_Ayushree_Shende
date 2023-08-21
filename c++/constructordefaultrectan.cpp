#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length,breadth;
		int a,perimeter;
rectangle()
	{
  length=0;
  breadth=0;		
}
float calculatearea()
{
	float a=length*breadth;
	return a;
}
float calculateperi()
{
float peri=2*(length+breadth);
return peri;
}
};
int main()
{
	 int result;
	rectangle r1;
	cout<<"enter length and breadth";
	cin>>r1.length>>r1.breadth;
	result=r1.calculatearea();
	cout<<"area is="<<result;
	result=r1.calculateperi();
	cout<<"perimeter is="<<result;
	return 0;
}
		

