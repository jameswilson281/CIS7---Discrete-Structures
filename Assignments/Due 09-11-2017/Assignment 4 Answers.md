# Assignment 4 Answers

## Explanation

Unfortunately my planner (iStudiez Pro) told me the assignment was due 9/12 but that wasn't proper.  Well anyways.

![](https://media.tenor.com/images/d21fb679d6ef61c6aa9576f899579311/tenor.gif)

### 1.

	Show that p -> q and q' -> p' are logically equivalent without using truth tables or a "contrapositive" law (don't assume they are true).

Answer

	q' -> p' <=> (q')' v p'  	 =  Implication

         	 <=> q v p'      	 =  Double Negation

        	 <=> p' v q      	 =  Commutative

             <=> p -> q      	 =  Implication

### 2.

	Show that (p -> r) ^ (q -> r) <=> (p v q) -> r

Answer 

	(p -> r) ^ (q -> r) <=> (p' v r) ^ (q' v r)     = Implication

                    	<=> (r v p') ^ (r v q')     = Commutative

                   	    <=> r v (p' ^ q')           = Distributive

                        <=> (p' ^ q') v r           = Commutative

                        <=> (p v q)' v r            = DeMorgan

                        <=> (p v q) -> r            = Implication

### 3.

	Come up with 2 more questions like the ones above. Incorporate the logic laws we discussed in class.

Answer

	(q’ -> (p’)’) ^ q’ <=> (q’ -> (p’)’) ^ q’
	
					   <=> (q’ -> p) ^ q'

					   <=> (q v p) ^ q'

					   <=> (q -> p) ^ q’

					   <=> (q’ ^ q) v (‘q ^ p)

					   <=> F v (‘q ^ p)

					   <=> ‘q ^ p

Answer 2
	
	(((q')' ^ q) v (q' v q) ^ q) <=> (((q')' ^ q) v (q' v q) ^ q)

						  		 <=> ((q ^ q) v (q' v q) ^ q)

						  		 <=> (F v T) ^ q)

						  		 <=> ((F ^ q) v (T ^ q))

						  		 <=> (T ^ q)

						  		 <=> q


## Apologies

Sorry for how late this is.

![](http://gifimage.net/wp-content/uploads/2017/08/im-sorry-gif-14.gif)

