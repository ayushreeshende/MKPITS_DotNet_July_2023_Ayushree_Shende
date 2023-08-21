#include<iostream>
using namespace std;
class shape
{
	public:
	  int x;
	  int y;
	  void getdata(int a, int b)
		{
			x=a;
			y=b;
		}
};
class rectangle
{
	public:
		int crarea(int l,int b)
		{
			int ra;
			ra=l*b;
			return ra;
		}
};
class triangle
{
	public:
		float ctarea(int h,int b)
		{
		float ta;
		ta=0.5f*h*b;
		return ta;
		}
};
int main()
{
	rectangle r;
	triangle t;
	int length,breadth,height,base;
	int ra;
	float ta;
	cout<<"enter length and breadth:";
	cin>>length>>breadth;
	ra=r.crarea(length,breadth);
	cout<<"area of rectangle"<<ra<<endl;
	cout<<"enter height and base:";
	cin>>height>>base;
	ta=t.ctarea(height,base);
	cout<<"area of triangle"<<ta;
	return 0;
}
