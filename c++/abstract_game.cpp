#include<iostream>
using namespace std;
class game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class tictactoo:public game
{
	public:
		void start()
		{
			cout<<"tictactoo is start"<<endl;
		}
		void play()
		{
			cout<<"tictactoo is play"<<endl;
		}
		void end()
		{
			cout<<"tictactoo is end"<<endl;
					}
};
class chess:public game
{
	public:
		void start()
		{
			cout<<"chess is start"<<endl;
		}
		void play()
		{
			cout<<"chess is play"<<endl;
		}
		void end()
		{
			cout<<"chess is end"<<endl;
		}
};
int main()
{
	tictactoo t;
	chess c;
	t.start();
	t.play();
	t.end();
	c.start();
	c.play();
	c.end();
	return 0;
}

