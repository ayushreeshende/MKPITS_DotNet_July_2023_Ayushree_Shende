#include<iostream>
using namespace std;
class engine
{
	private:
		string power;
		public:
			void getpower(string p)
			{
				power=p;
				
			}
			void start()
			{
				cout<<"engine is start"<<endl;
			}
			void stop()
			{
				cout<<"engine is stop"<<endl;
			}
};
class vertical
{
	private:
		string brand;
		public:
			void getbrand(string b)
{
	brand=b;
			}
			void accelerator()
			{
				cout<<"accelerating"<<endl;
						}
						void brake()
						{
							cout<<"brake"<<endl;
									}
									void display()
									{
										cout<<"brand:"<<brand<<endl;
										
												}
															
};
class car:public engine,public vehic
{
	public:
		void drive()
		{
			cout<<"car is driving"<<endl;
		}
		void park()
		{
			cout<<"car is park"<<endl;
		}
};
int main()
{
	car c1;
	c1.getbrand("scorpio");
	c1.display();
	c1.start();
	c1.drive()
	}

