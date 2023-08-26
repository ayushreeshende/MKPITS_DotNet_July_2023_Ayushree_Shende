#include<iostream>
using namespace std;
class ability
{
	private:
		string abilityname;
		public:
			void getaname(string an)
			{
				abilityname=an;
			}
			void display()
			{
				cout<<"ability"<<abilityname<<endl;
			}
};
class equipment
{
	private:
		string equipmentItem;
		public:
			void getequipmentItem(string ei)
			{
				equipmentItem=ei;
				
			}
			void display()
			{
				cout<<"equipmentitem"<<equipmentItem<<endl;
			}
			
};
class character:public ability,public equipment
{
	private:
		string charactername;
		public:
			void getname(string cn,string an,string ei)
			{
			charactername=cn;
			getaname(an);
			getequipmentItem(ei);
			
}
void displayc()
{
			cout<<"charactername:"<<charactername<<endl;
			ability::display();
			equipment::display();
}
};
int main()
{
	string charactername,abilityname,equipmentitem;
	character c1;
	c1.getname("alien","attack","gun");
	c1.displayc();
	return 0;
}


