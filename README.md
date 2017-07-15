# ShefferMultioperationRank4

This is my graduate [bachelor's project «A  software  product  for  describing fragments  of  the  structure  of  algebras  of  multioperations»](http://lib.eltech.ru/files/vkr/2017/bakalavri/3307/2017ВКР330770МАЛИНА.pdf) at the [Saint Petersburg Electrotechnical University "LETI", Russia](http://www.eltech.ru/en/study/faculties/faculty-of-computing-technologies-and-informatics).

Scientific director: [N. A. Peryazev](http://www.mathnet.ru/rus/person27879)

![equation](https://latex.codecogs.com/gif.latex?%5C%5C%5Ctextup%7BLet%20%7D%20A%20-%20%5Ctextup%7Bfinite%20set.%7D%20%5C%5C%5Ctextup%7Bn-ary%20operation%3A%20%7D%20h%20%3A%20A%5E%7Bn%7D%20%5Crightarrow%20A%20%5C%5C%5Ctextup%7Bn-ary%20multioperation%3A%20%7D%20f%20%3A%20A%5E%7Bn%7D%20%5Crightarrow%202%5E%7BA%7D%20%5C%5C%5Cleft%20%7C%20A%20%5Cright%20%7C%20%3D%20k%20%5Ctextup%7B%20-%20rank%20of%20multioperation%7D%20%5C%5C%5Ctextup%7BDenote%20by%20%7DM_%7BA%7D%5E%7B1%7D%5Ctextup%7B%20the%20set%20of%20all%20unary%20multioperations%20on%20A.%7D%20%5C%5C%5Ctextup%7BMultioperations%20%7D%20f%20%5Cin%20M_%7BA%7D%5E%7B1%7D%5Ctextup%7B%20could%20be%20expressed%20as%20mappings%20%7D%20%5C%5C%20%5Cbegin%7Bcenter%7D%20%5Ctextit%7Bf%3A%7D%20%5Cleft%20%5C%7B%202%5E%7B0%7D%2C%202%5E%7B1%7D%2C...%2C2%5E%7Bk-1%7D%20%5Cright%20%5C%7D%20%5Crightarrow%20%5Cleft%20%5C%7B%200%2C%201%2C%20...%2C%202%5E%7Bk-1%7D%20%5Cright%20%5C%7D%2C%20%5Cend%7Bcenter%7D)
![equation](https://latex.codecogs.com/gif.latex?%5Ctextup%7Bobtained%20from%20%7D%20f%20%5Ctextup%7B%20by%20encoding%7D%20%5C%5C%20%5Cbegin%7Bcenter%7D%20a_%7Bi%7D%5Crightarrow%202%5E%7Bi%7D%3B%20%5Co%20%5Crightarrow%200%3B%20%7Ba_%7B%7Bi%7D_%7B1%7D%7D%2C...%2Ca_%7B%7Bi%7D_%7Bs%7D%7D%7D%20%5Crightarrow%202%5E%7B%7Bi%7D_%7B1%7D%7D%20&plus;%20...%20&plus;%202%5E%7B%7Bi%7D_%7Bs%7D%7D%20%5Cend%7Bcenter%7D)
![equation](https://latex.codecogs.com/gif.latex?%5Ctext%7BWe%20define%20unary%20multioperation%20%7D%20f%20%5Ctext%7B%20in%20vector%20form%7D%20%28%5Calpha_%7B0%7D%2C...%2C%5Calpha_%7Bk-1%7D%29%2C%20%5C%5C%5Ctext%7Bwhere%20%7D%20f%28a_%7Bi%7D%29%20%3D%20%5Calpha_%7Bi%7D%20%5C%5C%5Ctext%7BLet%20%7D%20S%20%5Csubseteq%20M_%7BA%7D%5E%7B1%7D.%20%5Ctext%7B%20Algebra%20%7D%20%5Cmathfrak%7BF%7D%3D%20%3CS%3B%20*%2C%5Ccap%20%2C%5Cmu%20%2C%5Cvarepsilon%2C%20%5Ctheta%2C%20%5Cpi%20%3E%20%5Ctext%7B%20of%20type%20%7D%20%3C2%2C2%2C1%2C0%2C0%2C0%3E%20%5Ctext%7B%20with%20metaoperations%3A%20substitution%20%7D%20%28f*g%29%2C%20%5Ctext%7Bintersection%20%7D%20%28f%5Ccap%20g%29%2C%20%5Ctext%7Binvertibility%20%7D%20%28%5Cmu%20f%29%20%5Ctext%7B%20and%20nullary%20operations%20%7D%20%5Cvarepsilon%2C%20%5Ctheta%2C%20%5Cpi%20%5C%5C%5Ctext%7B%20called%20algebra%20of%20unary%20multioperations%20over%20%7D%20A%3A%20%5C%5C%28f*g%29%28a%29%3D%20%5C%7B%20b%20%7C%20%5Cexists%20c%20%5Cin%20g%28a%29%3A%20b%20%5Cin%20f%28c%29%20%5C%7D%3B%20%5C%5C%20%28f%5Ccap%20g%29%28a%29%20%3D%20f%28a%29%20%5Ccap%20g%28a%29%3B%20%5C%5C%28%5Cmu%20f%29%28a%29%20%3D%20%5C%7Bb%20%7C%20a%20%5Cin%20f%28b%29%20%5C%7D%3B%20%5C%5C%20%5Cvarepsilon%28a%29%20%3D%20%5C%7Ba%5C%7D%3B%20%5C%5C%20%5Ctheta%20%28a%29%20%3D%20%5Cvarnothing%20%3B%20%5C%5C%20%5Cpi%20%28a%29%20%3D%20A.%20%5C%5C%20%5Ctext%7BCardinality%20of%20set%20%7D%20A%20%5Ctext%7B%20is%20called%20rank%20of%20algebra%7D.%20%5C%5C%20%5Ctext%7BAlgebras%20ofunary%20multioperations%20were%20introduced%20in%20%5B1%5D%7D.)
![equation](https://latex.codecogs.com/gif.latex?%5C%5C%20%5C%5C%20%5Ctext%7BAn%20multioperation%20called%20Sheffer%20if%20it%20generates%20the%20whole%20algebra.%7D%20%5C%5C%20%5Ctext%7BIn%20the%20largest%20algebra%20of%20unary%20multioperations%20of%20rank%202%20there%20are%20no%7D%20%5C%5C%20%5Ctext%7BSheffer%20operations%2C%20but%20of%20rank%20of%203%20exists%2012%20operations%3A%20%7D%20%5C%5C%20%28243%29%2C%20%28251%29%2C%20%28253%29%2C%20%28413%29%2C%20%28452%29%2C%20%28453%29%2C%20%28612%29%2C%20%28613%29%2C%20%28641%29%2C%20%28643%29%2C%20%28651%29%2C%20%28652%29.%20%5C%5C%20%5Ctext%7BIn%20my%20work%20I%20found%20816%20Sheffer%20operations%20in%20full%20algebra%20of%20unary%20multioperations%20of%20rank%204.%7D)


