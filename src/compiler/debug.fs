require ../user.fs
require ./cross.fs

also gbforth-user

require ../../lib/core.fs

: max
  2dup < if nip else drop then ;

previous

\ x' max drop
xsee max
xname' max >xcode free-ir
