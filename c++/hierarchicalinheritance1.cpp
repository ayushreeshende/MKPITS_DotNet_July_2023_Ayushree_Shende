#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
		void getdata(int a,int b)
		{
			x=a;
			y=b;
			
		}
};
class rectangle:public shape
{
	public:
		int crarea()
		{
			int ra;
			ra=x*y;
			return ra;
		}
};
class triangle:public shape
{
	public:
		float ctarea()
		{
			float ta;
			ta=0.5f*x*y;
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
	cout<<"enter length and breadth";
	cin>>length>>breadth;
	r.getdata(length,breadth);
	ra=r.crarea();
	cout<<"area of rectangle"<<ra<<endl;
	cout<<"enter height and base";
	cin>>height>>base;
	t.getdata(height,base);
	ta=t.ctarea();
	cout<<"area of triangle"<<ta;
	return 0;
	
}
