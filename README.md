# apbd-cw1-git-s32959

5. Merge bez fast-forward 
Zrobiliśmy commity na obydwu branchach, zatem aby zachować historię tego 
gdzie jaki commit miał miejsce merge nie był fast-forward.

Pytania:
1. Git wykona fast-forward gdy na gałęzi z której wykonujemy merge nie było żadnych nowych commitów odkąd utworzyliśmy drugi branch. 
Merge commit powstaje natomiast gdy w wypadku na obydwu branchach doszło do zmian, ponieważ ważne jest zachowanie historii commitów obydwu branchy.
2. Merge nie zmienia gałęzi(widać historię commitów na każdej z gałęzi tak jak zachodziła). 
Mergujemy do gałęzi(czyli np. z feature na main)
Rebase natomiast przenosi cały branch na koniec drugiego(np. feature na main).
3. Manualnie usunąłem niepotrzebny zrefaktoryzowany kod i połączyłem resztę ze sobą.
