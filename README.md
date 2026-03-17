# apbd-cw1-git-s32959

5. Merge bez fast-forward 
Zrobiliśmy commity na obydwu branchach, zatem aby zachować historię tego 
gdzie jaki commit miał miejsce merge nie był fast-forward.

Pytania:
1. Git wykona fast-forward gdy tylko w jednej gałęzi doszło do zmian. Merge conflict powstaje w wypadku gdy przez
mergem lub rebasem modyfikowany był ten sam plik na gałęziach na których chcemy wykonać tą operację.
2. Merge nie zmienia gałęzi(widać historię commitów na każdej z gałęzi tak jak zachodziła). 
Mergujemy do gałęzi(czyli np. z feature na main)
Rebase natomiast przenosi cały branch na koniec drugiego(np. feature na main).
3. Manualnie usunąłem niepotrzebny zrefaktoryzowany kod i połączyłem resztę ze sobą.
