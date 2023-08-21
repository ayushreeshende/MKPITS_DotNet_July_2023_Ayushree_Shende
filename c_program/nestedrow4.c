#include<stdio.h>
void main()
{
	int col,row;
	for(row=3;row>=1;row--)
	{
		for(col=1;col<=row;col++)
		{
			printf("\t%d",col);
		}
		printf("\n");
	}
}
