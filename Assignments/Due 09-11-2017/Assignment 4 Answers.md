# Assignment 4 Answers

	Show that p -> q and q' -> p' are logically equivalent without using truth tables or a "contrapositive" law (don't assume they are true).

Answer

	q' -> p' <=> (q')' v p'  =  Implication

         <=> q v p'      	 =  Double Negation

         <=> p' v q      	 =  Commutative

         <=> p -> q      	 =  Implication

### 2.

	Show that (p -> r) ^ (q -> r) <=> (p v q) -> r

Answer 

	(p -> r) ^ (q -> r) <=> (p' v r) ^ (q' v r) = Implication

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



