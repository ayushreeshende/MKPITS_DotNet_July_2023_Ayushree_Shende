#include<iostream>
using namespace std;
class shape
{
	public:
		virtual void draw()=0;
		
};
class rectangle:public shape
{
	public:
		void draw()
		{
			cout<<"draw for rectangle";
		}
};
int main()
{
	rectangle r;
	r.draw();
	return 0;
}
