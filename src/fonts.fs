( IBMPC1 8x8 Character Set Macros V1.2 )

require ./rom.fs

vocabulary fonts

get-current
also fonts definitions
constant previous-wid

: discard-line 10 parse 2drop ;

: >
  parse-name
  dup 8 <> if true abort" The tile line length is wrong!" then
  0 swap
  0 ?do
    1 lshift
    over i + c@ case
      [char] X of 1 or endof
      [char] . of      endof
      true abort" Wrong character!"
    endcase
  loop 
  nip 
  rom, ;


> .XXXXXX.  \ Use to be a space ?????
> .X....X.
> .X....X.
> .X....X.
> .X....X.
> .X....X.
> .X....X.
> .XXXXXX.

> .XXXXXX.
> X......X
> X.X..X.X
> X......X
> X.XXXX.X
> X..XX..X
> X......X
> .XXXXXX.

> .XXXXXX.
> XXXXXXXX
> XX.XX.XX
> XXXXXXXX
> XX....XX
> XXX..XXX
> XXXXXXXX
> .XXXXXX.

> .XX.XX..
> XXXXXXX.
> XXXXXXX.
> XXXXXXX.
> .XXXXX..
> ..XXX...
> ...X....
> ........

> ...X....
> ..XXX...
> .XXXXX..
> XXXXXXX.
> .XXXXX..
> ..XXX...
> ...X....
> ........

> ..XXX...
> .XXXXX..
> ..XXX...
> XXXXXXX.
> XXXXXXX.
> .XXXXX..
> ..XXX...
> .XXXXX..

> ...X....
> ...X....
> ..XXX...
> .XXXXX..
> XXXXXXX.
> .XXXXX..
> ..XXX...
> .XXXXX..

> ........
> ........
> ...XX...
> ..XXXX..
> ..XXXX..
> ...XX...
> ........
> ........

> XXXXXXXX
> XXXXXXXX
> XXX..XXX
> XX....XX
> XX....XX
> XXX..XXX
> XXXXXXXX
> XXXXXXXX

> ........
> ..XXXX..
> .XX..XX.
> .X....X.
> .X....X.
> .XX..XX.
> ..XXXX..
> ........

> XXXXXXXX
> XX....XX
> X..XX..X
> X.XXXX.X
> X.XXXX.X
> X..XX..X
> XX....XX
> XXXXXXXX

> ....XXXX
> .....XXX
> ....XXXX
> .XXXXX.X
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...

> ..XXXX..
> .XX..XX.
> .XX..XX.
> .XX..XX.
> ..XXXX..
> ...XX...
> .XXXXXX.
> ...XX...

> ..XXXXXX
> ..XX..XX
> ..XXXXXX
> ..XX....
> ..XX....
> .XXX....
> XXXX....
> XXX.....

> .XXXXXXX
> .XX...XX
> .XXXXXXX
> .XX...XX
> .XX...XX
> .XX..XXX
> XXX..XX.
> XX......

> X..XX..X
> .X.XX.X.
> ..XXXX..
> XXX..XXX
> XXX..XXX
> ..XXXX..
> .X.XX.X.
> X..XX..X

> X.......
> XXX.....
> XXXXX...
> XXXXXXX.
> XXXXX...
> XXX.....
> X.......
> ........

> ......X.
> ....XXX.
> ..XXXXX.
> XXXXXXX.
> ..XXXXX.
> ....XXX.
> ......X.
> ........

> ...XX...
> ..XXXX..
> .XXXXXX.
> ...XX...
> ...XX...
> .XXXXXX.
> ..XXXX..
> ...XX...

> .XX..XX.
> .XX..XX.
> .XX..XX.
> .XX..XX.
> .XX..XX.
> ........
> .XX..XX.
> ........

> .XXXXXXX
> XX.XX.XX
> XX.XX.XX
> .XXXX.XX
> ...XX.XX
> ...XX.XX
> ...XX.XX
> ........

> ..XXXXX.
> .XX...XX
> ..XXX...
> .XX.XX..
> .XX.XX..
> ..XXX...
> XX..XX..
> .XXXX...

> ........
> ........
> ........
> ........
> .XXXXXX.
> .XXXXXX.
> .XXXXXX.
> ........

> ...XX...
> ..XXXX..
> .XXXXXX.
> ...XX...
> .XXXXXX.
> ..XXXX..
> ...XX...
> XXXXXXXX

> ...XX...
> ..XXXX..
> .XXXXXX.
> ...XX...
> ...XX...
> ...XX...
> ...XX...
> ........

> ...XX...
> ...XX...
> ...XX...
> ...XX...
> .XXXXXX.
> ..XXXX..
> ...XX...
> ........

> ........
> ...XX...
> ....XX..
> XXXXXXX.
> ....XX..
> ...XX...
> ........
> ........

> ........
> ..XX....
> .XX.....
> XXXXXXX.
> .XX.....
> ..XX....
> ........
> ........

> ........
> ........
> XX......
> XX......
> XX......
> XXXXXXX.
> ........
> ........

> ........
> ..X..X..
> .XX..XX.
> XXXXXXXX
> .XX..XX.
> ..X..X..
> ........
> ........

> ........
> ...XX...
> ..XXXX..
> .XXXXXX.
> XXXXXXXX
> XXXXXXXX
> ........
> ........

> ........
> XXXXXXXX
> XXXXXXXX
> .XXXXXX.
> ..XXXX..
> ...XX...
> ........
> ........

> ........
> ........
> ........
> ........
> ........
> ........
> ........
> ........

> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ........
> ..XX....
> ........

> .XX.XX..
> .XX.XX..
> .XX.XX..
> ........
> ........
> ........
> ........
> ........

> .XX.XX..
> .XX.XX..
> XXXXXXX.
> .XX.XX..
> XXXXXXX.
> .XX.XX..
> .XX.XX..
> ........

> ..XX....
> .XXXXX..
> XX......
> .XXXX...
> ....XX..
> XXXXX...
> ..XX....
> ........

> ........
> XX...XX.
> XX..XX..
> ...XX...
> ..XX....
> .XX..XX.
> XX...XX.
> ........

> ..XXX...
> .XX.XX..
> ..XXX...
> .XXX.XX.
> XX.XXX..
> XX..XX..
> .XXX.XX.
> ........

> .XX.....
> .XX.....
> XX......
> ........
> ........
> ........
> ........
> ........

> ...XX...
> ..XX....
> .XX.....
> .XX.....
> .XX.....
> ..XX....
> ...XX...
> ........

> .XX.....
> ..XX....
> ...XX...
> ...XX...
> ...XX...
> ..XX....
> .XX.....
> ........

> ........
> .XX..XX.
> ..XXXX..
> XXXXXXXX
> ..XXXX..
> .XX..XX.
> ........
> ........

> ........
> ..XX....
> ..XX....
> XXXXXX..
> ..XX....
> ..XX....
> ........
> ........

> ........
> ........
> ........
> ........
> ........
> ..XX....
> ..XX....
> .XX.....

> ........
> ........
> ........
> XXXXXX..
> ........
> ........
> ........
> ........

> ........
> ........
> ........
> ........
> ........
> ..XX....
> ..XX....
> ........

> .....XX.
> ....XX..
> ...XX...
> ..XX....
> .XX.....
> XX......
> X.......
> ........

> .XXXXX..
> XX...XX.
> XX..XXX.
> XX.XXXX.
> XXXX.XX.
> XXX..XX.
> .XXXXX..
> ........

> ..XX....
> .XXX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> XXXXXX..
> ........

> .XXXX...
> XX..XX..
> ....XX..
> ..XXX...
> .XX.....
> XX..XX..
> XXXXXX..
> ........

> .XXXX...
> XX..XX..
> ....XX..
> ..XXX...
> ....XX..
> XX..XX..
> .XXXX...
> ........

> ...XXX..
> ..XXXX..
> .XX.XX..
> XX..XX..
> XXXXXXX.
> ....XX..
> ...XXXX.
> ........

> XXXXXX..
> XX......
> XXXXX...
> ....XX..
> ....XX..
> XX..XX..
> .XXXX...
> ........

> ..XXX...
> .XX.....
> XX......
> XXXXX...
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> XXXXXX..
> XX..XX..
> ....XX..
> ...XX...
> ..XX....
> ..XX....
> ..XX....
> ........

> .XXXX...
> XX..XX..
> XX..XX..
> .XXXX...
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> .XXXX...
> XX..XX..
> XX..XX..
> .XXXXX..
> ....XX..
> ...XX...
> .XXX....
> ........

> ........
> ..XX....
> ..XX....
> ........
> ........
> ..XX....
> ..XX....
> ........

> ........
> ..XX....
> ..XX....
> ........
> ........
> ..XX....
> ..XX....
> .XX.....

> ...XX...
> ..XX....
> .XX.....
> XX......
> .XX.....
> ..XX....
> ...XX...
> ........

> ........
> ........
> XXXXXX..
> ........
> ........
> XXXXXX..
> ........
> ........

> .XX.....
> ..XX....
> ...XX...
> ....XX..
> ...XX...
> ..XX....
> .XX.....
> ........

> .XXXX...
> XX..XX..
> ....XX..
> ...XX...
> ..XX....
> ........
> ..XX....
> ........

> .XXXXX..
> XX...XX.
> XX.XXXX.
> XX.XXXX.
> XX.XXXX.
> XX......
> .XXXX...
> ........

> ..XX....
> .XXXX...
> XX..XX..
> XX..XX..
> XXXXXX..
> XX..XX..
> XX..XX..
> ........

> XXXXXX..
> .XX..XX.
> .XX..XX.
> .XXXXX..
> .XX..XX.
> .XX..XX.
> XXXXXX..
> ........

> ..XXXX..
> .XX..XX.
> XX......
> XX......
> XX......
> .XX..XX.
> ..XXXX..
> ........

> XXXXX...
> .XX.XX..
> .XX..XX.
> .XX..XX.
> .XX..XX.
> .XX.XX..
> XXXXX...
> ........

> .XXXXXX.
> .XX.....
> .XX.....
> .XXXX...
> .XX.....
> .XX.....
> .XXXXXX.
> ........

> .XXXXXX.
> .XX.....
> .XX.....
> .XXXX...
> .XX.....
> .XX.....
> .XX.....
> ........

> ..XXXX..
> .XX..XX.
> XX......
> XX......
> XX..XXX.
> .XX..XX.
> ..XXXXX.
> ........

> XX..XX..
> XX..XX..
> XX..XX..
> XXXXXX..
> XX..XX..
> XX..XX..
> XX..XX..
> ........

> .XXXX...
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> .XXXX...
> ........

> ...XXXX.
> ....XX..
> ....XX..
> ....XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> XXX..XX.
> .XX..XX.
> .XX.XX..
> .XXXX...
> .XX.XX..
> .XX..XX.
> XXX..XX.
> ........

> .XX.....
> .XX.....
> .XX.....
> .XX.....
> .XX.....
> .XX.....
> .XXXXXX.
> ........

> XX...XX.
> XXX.XXX.
> XXXXXXX.
> XXXXXXX.
> XX.X.XX.
> XX...XX.
> XX...XX.
> ........

> XX...XX.
> XXX..XX.
> XXXX.XX.
> XX.XXXX.
> XX..XXX.
> XX...XX.
> XX...XX.
> ........

> ..XXX...
> .XX.XX..
> XX...XX.
> XX...XX.
> XX...XX.
> .XX.XX..
> ..XXX...
> ........

> XXXXXX..
> .XX..XX.
> .XX..XX.
> .XXXXX..
> .XX.....
> .XX.....
> XXXX....
> ........

> .XXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> XX.XXX..
> .XXXX...
> ...XXX..
> ........

> XXXXXX..
> .XX..XX.
> .XX..XX.
> .XXXXX..
> .XX.XX..
> .XX..XX.
> XXX..XX.
> ........

> .XXXX...
> XX..XX..
> XXX.....
> .XXXX...
> ...XXX..
> XX..XX..
> .XXXX...
> ........

> XXXXXX..
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ........

> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> XXXXXX..
> ........

> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ..XX....
> ........

> XX...XX.
> XX...XX.
> XX...XX.
> XX.X.XX.
> XXXXXXX.
> XXX.XXX.
> XX...XX.
> ........

> XX...XX.
> XX...XX.
> .XX.XX..
> ..XXX...
> ..XXX...
> .XX.XX..
> XX...XX.
> ........

> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ..XX....
> ..XX....
> .XXXX...
> ........

> XXXXXXX.
> .....XX.
> ....XX..
> ...XX...
> ..XX....
> .XX.....
> XXXXXXX.
> ........

> .XXXX...
> .XX.....
> .XX.....
> .XX.....
> .XX.....
> .XX.....
> .XXXX...
> ........

> XX......
> .XX.....
> ..XX....
> ...XX...
> ....XX..
> .....XX.
> ......X.
> ........

> .XXXX...
> ...XX...
> ...XX...
> ...XX...
> ...XX...
> ...XX...
> .XXXX...
> ........

> ...X....
> ..XXX...
> .XX.XX..
> XX...XX.
> ........
> ........
> ........
> ........

> ........
> ........
> ........
> ........
> ........
> ........
> ........
> XXXXXXXX

> ..XX....
> ..XX....
> ...XX...
> ........
> ........
> ........
> ........
> ........

> ........
> ........
> .XXXX...
> ....XX..
> .XXXXX..
> XX..XX..
> .XXX.XX.
> ........

> XXX.....
> .XX.....
> .XX.....
> .XXXXX..
> .XX..XX.
> .XX..XX.
> XX.XXX..
> ........

> ........
> ........
> .XXXX...
> XX..XX..
> XX......
> XX..XX..
> .XXXX...
> ........

> ...XXX..
> ....XX..
> ....XX..
> .XXXXX..
> XX..XX..
> XX..XX..
> .XXX.XX.
> ........

> ........
> ........
> .XXXX...
> XX..XX..
> XXXXXX..
> XX......
> .XXXX...
> ........

> ..XXX...
> .XX.XX..
> .XX.....
> XXXX....
> .XX.....
> .XX.....
> XXXX....
> ........

> ........
> ........
> .XXX.XX.
> XX..XX..
> XX..XX..
> .XXXXX..
> ....XX..
> XXXXX...

> XXX.....
> .XX.....
> .XX.XX..
> .XXX.XX.
> .XX..XX.
> .XX..XX.
> XXX..XX.
> ........

> ..XX....
> ........
> .XXX....
> ..XX....
> ..XX....
> ..XX....
> .XXXX...
> ........

> ....XX..
> ........
> ....XX..
> ....XX..
> ....XX..
> XX..XX..
> XX..XX..
> .XXXX...

> XXX.....
> .XX.....
> .XX..XX.
> .XX.XX..
> .XXXX...
> .XX.XX..
> XXX..XX.
> ........

> .XXX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> .XXXX...
> ........

> ........
> ........
> XX..XX..
> XXXXXXX.
> XXXXXXX.
> XX.X.XX.
> XX...XX.
> ........

> ........
> ........
> XXXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> ........

> ........
> ........
> .XXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> ........
> ........
> XX.XXX..
> .XX..XX.
> .XX..XX.
> .XXXXX..
> .XX.....
> XXXX....

> ........
> ........
> .XXX.XX.
> XX..XX..
> XX..XX..
> .XXXXX..
> ....XX..
> ...XXXX.

> ........
> ........
> XX.XXX..
> .XXX.XX.
> .XX..XX.
> .XX.....
> XXXX....
> ........

> ........
> ........
> .XXXXX..
> XX......
> .XXXX...
> ....XX..
> XXXXX...
> ........

> ...X....
> ..XX....
> .XXXXX..
> ..XX....
> ..XX....
> ..XX.X..
> ...XX...
> ........

> ........
> ........
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> .XXX.XX.
> ........

> ........
> ........
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ..XX....
> ........

> ........
> ........
> XX...XX.
> XX.X.XX.
> XXXXXXX.
> XXXXXXX.
> .XX.XX..
> ........

> ........
> ........
> XX...XX.
> .XX.XX..
> ..XXX...
> .XX.XX..
> XX...XX.
> ........

> ........
> ........
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXXX..
> ....XX..
> XXXXX...

> ........
> ........
> XXXXXX..
> X..XX...
> ..XX....
> .XX..X..
> XXXXXX..
> ........

> ...XXX..
> ..XX....
> ..XX....
> XXX.....
> ..XX....
> ..XX....
> ...XXX..
> ........

> ...XX...
> ...XX...
> ...XX...
> ........
> ...XX...
> ...XX...
> ...XX...
> ........

> XXX.....
> ..XX....
> ..XX....
> ...XXX..
> ..XX....
> ..XX....
> XXX.....
> ........

> .XXX.XX.
> XX.XXX..
> ........
> ........
> ........
> ........
> ........
> ........

> ........
> ...X....
> ..XXX...
> .XX.XX..
> XX...XX.
> XXXXXXX.
> ........
> ........

> ..XXXX..
> .XX..XX.
> XX......
> XX......
> .XX..XX.
> ..XXXX..
> ....X...
> ...XX...

> ..X.X...
> ........
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> .XXX.XX.
> ........

> ....X...
> ...X....
> .XXXX...
> XX..XX..
> XXXXXX..
> XX......
> .XXXX...
> ........

> ...X....
> ..X.X...
> .XXXX...
> ....XX..
> .XXXXX..
> XX..XX..
> .XXX.XX.
> ........

> ..X.X...
> ........
> .XXXX...
> ....XX..
> .XXXXX..
> XX..XX..
> .XXX.XX.
> ........

> ..X.....
> ...X....
> .XXXX...
> ....XX..
> .XXXXX..
> XX..XX..
> .XXX.XX.
> ........

> ...XX...
> ...XX...
> .XXXX...
> ....XX..
> .XXXXX..
> XX..XX..
> .XXX.XX.
> ........

> ........
> .XXXX...
> XX..XX..
> XX......
> XX..XX..
> .XXXX...
> ...X....
> ..XX....

> ...X....
> ..X.X...
> .XXXX...
> XX..XX..
> XXXXXX..
> XX......
> .XXXX...
> ........

> ..X.X...
> ........
> .XXXX...
> XX..XX..
> XXXXXX..
> XX......
> .XXXX...
> ........

> ..X.....
> ...X....
> .XXXX...
> XX..XX..
> XXXXXX..
> XX......
> .XXXX...
> ........

> ..X.X...
> ........
> .XXX....
> ..XX....
> ..XX....
> ..XX....
> .XXXX...
> ........

> ...X....
> ..X.X...
> .XXX....
> ..XX....
> ..XX....
> ..XX....
> .XXXX...
> ........

> ...X....
> ....X...
> .XXX....
> ..XX....
> ..XX....
> ..XX....
> .XXXX...
> ........

> ..X.X...
> ..XX....
> .XXXX...
> XX..XX..
> XXXXXX..
> XX..XX..
> XX..XX..
> ........

> ..XX....
> .X..X...
> ..XX....
> XX..XX..
> XXXXXX..
> XX..XX..
> XX..XX..
> ........

> ....X...
> ...X....
> .XXXXXX.
> .XX.....
> .XXXX...
> .XX.....
> .XXXXXX.
> ........

> ........
> ........
> .XX.XX..
> ...X..X.
> .XXXXXX.
> X..X....
> .XXXXXX.
> ........

> ..XXXXX.
> .X.X....
> X..X....
> X..XXX..
> XXXX....
> X..X....
> X..XXXX.
> ........

> ...X....
> ..X.X...
> .XXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> ..X.X...
> ........
> .XXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> ..X.....
> ...X....
> .XXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> ...X....
> ..X.X...
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> .XXX.XX.
> ........

> ..X.....
> ...X....
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> .XXX.XX.
> ........

> ..X.X...
> ........
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXXX..
> ....XX..
> XXXXX...

> ..X.X...
> .XXXXX..
> XX...XX.
> XX...XX.
> XX...XX.
> XX...XX.
> .XXXXX..
> ........

> ..X.X...
> XX...XX.
> XX...XX.
> XX...XX.
> XX...XX.
> XX...XX.
> .XXXXX..
> ........

> ........
> ...X....
> .XXXX...
> XX..XX..
> XX......
> XX..XX..
> .XXXX...
> ...X....

> ..XXX...
> .X...X..
> .X......
> XXXX....
> .X......
> .X......
> XXXXXXX.
> ........

> XX....XX
> .XX..XX.
> ..XXXX..
> .XXXXXX.
> ...XX...
> .XXXXXX.
> ...XX...
> ........

> XXXXXX..
> .XX..XX.
> .XX..XX.
> .XXXXX..
> .XX.....
> .XX.....
> XXXX....
> ........

> ...XXX..
> ..XX....
> XXXXXX..
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> XXX.....

> ....X...
> ...X....
> .XXXX...
> ....XX..
> .XXXXX..
> XX..XX..
> .XXX.XX.
> ........

> ...X....
> ..X.....
> .XXX....
> ..XX....
> ..XX....
> ..XX....
> .XXXX...
> ........

> ...X....
> ..X.....
> .XXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> .XXXX...
> ........

> ...X....
> ..X.....
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> .XXX.XX.
> ........

> ..XX..X.
> .X..XX..
> XXXXX...
> XX..XX..
> XX..XX..
> XX..XX..
> XX..XX..
> ........

> ..XX..X.
> .X..XX..
> XX...XX.
> XXX..XX.
> XX.X.XX.
> XX..XXX.
> XX...XX.
> ........

> ........
> ..XXX...
> ....XX..
> ..XXXX..
> .XX.XX..
> ..XX.XX.
> ........
> ........

> ........
> ..XXX...
> .X...X..
> .X...X..
> ..XXX...
> ........
> ........
> ........

> ...XX...
> ........
> ...XX...
> ..XX....
> .XX.....
> .XX..XX.
> ..XXXX..
> ........

> ........
> ........
> XXXXXXX.
> X.......
> X.......
> ........
> ........
> ........

> ........
> ........
> XXXXXXX.
> ......X.
> ......X.
> ........
> ........
> ........

> .X....X.
> .X...X..
> .X..X...
> .X.X.XX.
> ..X.X..X
> .X...XX.
> X...X...
> ...XXXXX

> .X....X.
> .X...X..
> .X..X...
> .X.X.XX.
> ..X.X.X.
> .X.XXXXX
> X.....X.
> .....XXX

> ..XX....
> ........
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ..XX....
> ........

> ........
> ..X..X..
> .X..X...
> X..X....
> .X..X...
> ..X..X..
> ........
> ........

> ........
> .X..X...
> ..X..X..
> ...X..X.
> ..X..X..
> .X..X...
> ........
> ........

> X...X...
> ..X...X.
> X...X...
> ..X...X.
> X...X...
> ........
> X...X...
> ..X...X.

> X.X.X.X.
> .X.X.X.X
> X.X.X.X.
> .X.X.X.X
> X.X.X.X.
> ........
> X.X.X.X.
> .X.X.X.X

> .XXX.XXX
> XX.XXX.X
> .XXX.XXX
> XX.XXX.X
> .XXX.XXX
> XXXXXXXX
> .XXX.XXX
> XX.XXX.X

> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....

> ...X....
> ...X....
> ...X....
> XXXX....
> ...X....
> ...X....
> ...X....
> ...X....

> ...X....
> ...X....
> XXXX....
> ...X....
> XXXX....
> ...X....
> ...X....
> ...X....

> ..X.X...
> ..X.X...
> ..X.X...
> XXX.X...
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ........
> ........
> ........
> XXXXX...
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ........
> ........
> XXXX....
> ...X....
> XXXX....
> ...X....
> ...X....
> ...X....

> ..X.X...
> ..X.X...
> XXX.X...
> ....X...
> XXX.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ........
> ........
> XXXXX...
> ....X...
> XXX.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ..X.X...  \ bc
> ..X.X...
> XXX.X...
> ....X...
> XXXXX...
> ........
> ........
> ........

> ..X.X...
> ..X.X...
> ..X.X...
> XXXXX...
> ........
> ........
> ........
> ........

> ...X....  \ be
> ...X....
> XXXX....
> ...X....
> XXXX....
> ........
> ........
> ........

> ........
> ........
> ........
> XXXX....
> ...X....
> ...X....
> ...X....
> ...X....

> ...X....
> ...X....
> ...X....
> ...XXXXX
> ........
> ........
> ........
> ........

> ...X....
> ...X....
> ...X....
> XXXXXXXX
> ........
> ........
> ........
> ........

> ........  \ c2
> ........
> ........
> XXXXXXXX
> ...X....
> ...X....
> ...X....
> ...X....

> ...X....
> ...X....
> ...X....
> ...XXXXX
> ...X....
> ...X....
> ...X....
> ...X....

> ........ \ c4
> ........
> ........
> XXXXXXXX
> ........
> ........
> ........
> ........

> ...X....
> ...X....
> ...X....
> XXXXXXXX
> ...X....
> ...X....
> ...X....
> ...X....

> ...X.... \ c6
> ...X....
> ...XXXXX
> ...X....
> ...XXXXX
> ...X....
> ...X....
> ...X....

> ..X.X...
> ..X.X...
> ..X.X...
> ..X.XXXX
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ..X.X... \ c8
> ..X.X...
> ..X.XXXX
> ..X.....
> ..XXXXXX
> ........
> ........
> ........

> ........
> ........
> ..XXXXXX
> ..X.....
> ..X.XXXX
> ..X.X...
> ..X.X...
> ..X.X...

> ..X.X... \ ca
> ..X.X...
> XXX.XXXX
> ........
> XXXXXXXX
> ........
> ........
> ........

> ........
> ........
> XXXXXXXX
> ........
> XXX.XXXX
> ..X.X...
> ..X.X...
> ..X.X...

> ..X.X... \ cc
> ..X.X...
> ..X.XXXX
> ..X.....
> ..X.XXXX
> ..X.X...
> ..X.X...
> ..X.X...

> ........
> ........
> XXXXXXXX
> ........
> XXXXXXXX
> ........
> ........
> ........

> ..X.X...
> ..X.X...
> XXX.XXXX
> ........
> XXX.XXXX
> ..X.X...
> ..X.X...
> ..X.X...

> ...X....
> ...X....
> XXXXXXXX
> ........
> XXXXXXXX
> ........
> ........
> ........

> ..X.X...
> ..X.X...
> ..X.X...
> XXXXXXXX
> ........
> ........
> ........
> ........

> ........
> ........
> XXXXXXXX
> ........
> XXXXXXXX
> ...X....
> ...X....
> ...X....

> ........
> ........
> ........
> XXXXXXXX
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ..X.X...
> ..X.X...
> ..X.X...
> ..XXXXXX
> ........
> ........
> ........
> ........

> ...X....
> ...X....
> ...XXXXX
> ...X....
> ...XXXXX
> ........
> ........
> ........

> ........
> ........
> ...XXXXX
> ...X....
> ...XXXXX
> ...X....
> ...X....
> ...X....

> ........
> ........
> ........
> ..XXXXXX
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ..X.X...
> ..X.X...
> ..X.X...
> XXXXXXXX
> ..X.X...
> ..X.X...
> ..X.X...
> ..X.X...

> ...X....
> ...X....
> XXXXXXXX
> ...X....
> XXXXXXXX
> ...X....
> ...X....
> ...X....

> ...X....
> ...X....
> ...X....
> XXXX....
> ........
> ........
> ........
> ........

> ........
> ........
> ........
> ...XXXXX
> ...X....
> ...X....
> ...X....
> ...X....

> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX

> ........
> ........
> ........
> ........
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX

> XXXX....
> XXXX....
> XXXX....
> XXXX....
> XXXX....
> XXXX....
> XXXX....
> XXXX....

> ....XXXX
> ....XXXX
> ....XXXX
> ....XXXX
> ....XXXX
> ....XXXX
> ....XXXX
> ....XXXX

> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> ........
> ........
> ........
> ........

> ........
> ........
> ........
> .XXX..X.
> X...XX..
> X...X...
> ..XXX.X. \ bug?
> ........

> ..XX....
> .X..X...
> .X..X...
> .XXXXX..
> .X....X.
> .X....X.
> XX.XXX..
> ........

> ........
> ........
> XXXXXXX.
> .X....X.
> .X......
> .X......
> XXX.....
> ........

> ........
> ........
> XXXXXXX.
> .X...X..
> .X...X..
> .X...X..
> XXX.XXX.
> ........

> XXXXXXX.
> .X....X.
> ..X.....
> ...X....
> ..X.....
> .X....X.
> XXXXXXX.
> ........

> ........
> ........
> ........
> ..XXXXX.
> .X...X..
> .X...X..
> ..XXX...
> ........

> ........
> ........
> XX..XX..
> .X...X..
> .X...X..
> .X...X..
> .XXXX.X.
> .X......

> ........
> ........
> .XXXXX..
> ...X....
> ...X....
> ...X....
> ...XXX..
> ........

> ........
> ...X....
> .XXXXX..
> X..X..X.
> X..X..X.
> .XXXXX..
> ...X....
> ........

> ........
> ........
> .XXXXX..
> X.....X.
> X.XXX.X.
> X.....X.
> .XXXXX..
> ........
> ........

> ........
> ........
> .XXXXX..
> X.....X.
> X.....X.
> .XX.XX..
> ..X.X...
> XXX.XXX.
> ........

> ........
> .XXXXX..
> ..X.....
> ..XXX...
> .X...X..
> .X...X..
> ..XXX...
> ........

> ........
> ........
> .XX.XX..
> X..X..X.
> X..X..X.
> .XX.XX..
> ........
> ........

> ........
> ........
> .X..XX..
> X..X..X.
> X..X..X.
> .XXXXX..
> ...X....
> ........

> ........
> ........
> ..XXXX..
> .X......
> ..XX....
> .X......
> ..XXXX..
> ........

> ........
> ........
> ..XXXX..
> .X....X.
> .X....X.
> .X....X.
> .X....X.
> ........

> ........
> XXXXXXX.
> ........
> XXXXXXX.
> ........
> XXXXXXX.
> ........
> ........

> ...X....
> ...X....
> XXXXXXX.
> ...X....
> ...X....
> XXXXXXX.
> ........
> ........

> .X......
> ...X....
> .....X..
> ...X....
> .X......
> XXXXXXX.
> ........
> ........

> .....X..
> ...X....
> .X......
> ...X....
> .....X..
> XXXXXXX.
> ........
> ........

> ....XX..
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....

> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> ...X....
> .XX.....

> ........
> ........
> ...X....
> ........
> XXXXXXX.
> ........
> ...X....
> ........

> ........
> .XX...X.
> X..XXX..
> ........
> .XX...X.
> X..XXX..
> ........
> ........

> ..XX....
> .X..X...
> .X..X...
> ..XX....
> ........
> ........
> ........
> ........

> ........
> ........
> ........
> ..XX....
> ..XX....
> ........
> ........
> ........

> ........
> ........
> ........
> ........
> ....X...
> ........
> ........
> ........

> .......X
> ......X.
> XXX...X.
> ..X..X..
> ...X.X..
> ...XX...
> ....X...
> ........

> ........
> ........
> .X.XX...
> ..X..X..
> ..X..X..
> ........
> ........
> ........

> ..XX....
> .X..X...
> ...X....
> ..X.....
> .XXXX...
> ........
> ........
> ........

> ........
> ........
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> XXXXXXXX
> ........
> ........

> ........
> ........
> ........
> ........
> ........
> ........
> ........
> ........

previous-wid set-current
previous
