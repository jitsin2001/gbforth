[asm]

: test
  $5678 $1234 <
  $6789 $abcd <
  $aa88 $aa55 <
  $aa22 $aa44 <
  $4444 $4444 < ;

main: ' test # call,
begin, halt, repeat,

[endasm]
