#include<stdio.h>
int main()
{
	int row,col;
	int arr1[2][2];
	int arr2[2][2];
	int i;
	printf("enter first matrices\n :");
		for(row=0;row<2;row++)
		{
			for(col=0;col<2;col++)
			{
				scanf("%d",&arr1[row][col]);
			}
		}
		printf("enter second matrices\n :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr2[row][col]);
		}
	}
	i=1;
		for(row=0;row<i;row++)
		{
			for(col=0;col<2;col++)
			{
		if(arr1[row][col]=arr2[row][col]);
	i=0;
	break;
}
}
if(i==1)
{
	printf("it is equal");
}
else
{
	printf("it is not equal");
}
}



Algorithm:
	1)start
	2)declare row,col,arr[2][2]
	3)accept first matrices
	4)for(row=0;row<2;row++)
	5)for (col=0;col<2;col++)
6)accept second matrices
7)for(row=0;row<2;row++)
8)for(col=0;col<2;col++)
9)if()	

		
			
			
		
	

