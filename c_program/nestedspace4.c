#include<stdio.h>
void main()
{
	int row,col,spc,k;
	spc=row+6-1;
	for(row=1;row<=9;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf("  ");
		}
		for(col=1;col<=row;col++)
		{
			printf(" * " );
		}
	spc--;
	printf("\n");
}

}
