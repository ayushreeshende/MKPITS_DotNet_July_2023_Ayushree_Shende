#include<stdio.h>
int main()
{
	int row,col;
	int arr1[2][2];
	int arr2[2][2];
	printf("enter matrices :");
		for(row=0;row<2;row++)
		{
			for(col=0;col<2;col++)
			{
				scanf("%d",&arr1[row][col]);
			}
		}	
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr2[row][col]=arr1[col][row];
		}
	}
			printf("transpose of matrices\n");
			for(row=0;row<2;row++)
			{
			for(col=0;col<2;col++)
			{
				printf("%d\t",arr2[row][col]);
		}
		printf("\n");
		}
	}

