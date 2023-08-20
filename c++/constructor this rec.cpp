#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length,breadth;
		int a,perimeter;
rectangle(int length,int breadth)
	{
		this->breadth=breadth;
		this->length=length;
  length=length;
  breadth=breadth;		
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
	 int result,length,breadth;
	rectangle r1(length,breadth);
	cout<<"enter length and breadth";
	cin>>r1.length>>r1.breadth;
	result=r1.calculatearea();
	cout<<"area is="<<result;
	result=r1.calculateperi();
	cout<<"perimeter is="<<result;
	return 0;
}
		

