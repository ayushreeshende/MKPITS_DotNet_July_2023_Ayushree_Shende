#include<iostream>
using namespace std;
class vehicle
{
	public:
		
		virtual void start()
		{
			cout<<"vehicle start"<<endl;
		}
		virtual void stop()
		{
			cout<<"vehicle stop"<<endl;
		}
};
class car:public vehicle
{
	public:
		void start()
		{
			cout<<"car is start"<<endl;
		}
		void stop()
		{
			cout<<"car is stop"<<endl;
		}
};
class motorcycle:public vehicle
{
	public:
		void start()
		{
			cout<<"motorcycle is start"<<endl;
		}
		void stop()
		{
			cout<<"motorcycle is stop"<<endl;
		}
};
class truck:public vehicle
{
	public:
		void start()
		{
			cout<<"truck is start"<<endl;
		}
		void stop()
		{
			cout<<"truck is stop"<<endl;
		}
};
int main()
{
	vehicle *V;
	car c;
	motorcycle m;
	truck t;
	V=&c;
	V->start();
	V->stop();
	V=&m;
	V->start();
	V->stop();
	V=&t;
	V->start();
	V->stop();
	return 0;
	
}
