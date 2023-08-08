#include<stdio.h>
void main()
{
	int row,col,spc,k;
	spc=row+6-1;
	for(row=1;row<=7;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf(" ");
		}
		for(col=1;col<=row;col++)
		{
			if(row%2!=0)
			printf("* " );
		}
	spc--;
	printf("\n");
}

}
