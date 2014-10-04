all: demo.o
	g++ demo.o -Wall -g -pthread -std=c++11 -mtune=native -Ofast  -o demo
demo.o: demo.cpp
	g++ -Wall -g -pthread -std=c++11 -mtune=native -Ofast -c demo.cpp 

clean:
	rm -rf *.o demo
