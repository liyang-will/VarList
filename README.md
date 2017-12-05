# VarList自定义数据类

>在一个大型项目中，.Net自带的**int,string,bool,float**等数据类型的数据结构可能不够我们使用，我们迫切需要一个**支持所有类型，并且长度可自由伸缩的数据结构**，使用它在项目模块中可以灵活进行传参和解析数据，大大加快开发进度。现在分享一下我之前项目设计的自定义数据类，设计思想以及实现原理，如有更好的建议，欢迎各位拍砖提出。

我的自定义类叫**VarList**，**var**代表任意类型，**List**是内部实现使用存储数据的容器。
**源码下载地址：**

###**实现思想：**

####**1、为什么使用VarList，有什么好处？**

**理由：**我们知道，设计底层API是对程序员设计思想的一种考验，需要考虑并熟悉项目中的应用场景，需求以及业务逻辑，最后提取出API功能，是设计API必不可少的功课，在不同场景，不同功能需要的参数也会不一样，有可能同一套逻辑仅仅是因为参数不同需要写多个API，这样明显是不合理的设计，这时候使用VarList就可以完美解决问题，因为它不仅变长，并且支持所有类型，同时使得底层API使用统一的参数数据类型，这样也更符合规范和利于代码管理。


####**2、为什么使用List作为数据存储容器？**

**List<T>**类是 ArrayList 类的泛型等效类。该类使用大小可按需动态增加的数组实现 IList<T> 泛型接口，可以帮助拓展数据量的大小

**好处：** 它使用了泛型为c#语言编写面向对象程序增加了极大的效力和灵活性。不会强行对值类型进行装箱和拆箱，或对引用类型进行向下强制类型转换，所以性能得到提高。

#### **3、它为什么可以支持所有类型？**
我们知道，.Net中的所有数据基类都是object，而object中有一个拓展方法：**ToString**,同时字符串（String）类型 允许给变量分配任何字符串值，其他类型的数据都可以和string类型相互转化，所以使用string作为内部实现容器List的类型 => **List< string >**
**内部源码截图：**
![这里写图片描述](http://img.blog.csdn.net/20171205194507665?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvbmluaV9ib29t/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/SouthEast)

#### **4、 它有哪些方法来操作数据？**
+ **增：**
   内部实现拥有一组API：**Append方法，**利用重载的原理，自动识别出传入参数的类型，然后将其放入数据容器，**List的长度也随之增加。**
+ **取：**
  **SubValue方法系列，**内部实现提供了**SubIntValue，SubFloatValue，SubStringValue**等等方法，从方法名即可看出，是对不同类型数据的取出方法，**注意：取出后List原先的长度也随之减一**
+ **改：**
  **SetValue方法系列，**内部实现提供了**SetIntValue，SetFloatValue，SetStringValue**等等方法，从方法名即可看出，是对自定义中不同类型数据的修改方法。
+ **查：**
  **AtIndexOfValue方法系列，**内部实现提供了**AtIndexOfIntValue，AtIndexOfFloatValue，AtIndexOfStringValue**等等方法，从方法名即可看出，是对自定义中不同类型数据的查找方法。

#### **5、 如何使用？**
####**使用截图：**
![这里写图片描述](http://img.blog.csdn.net/20171205194652091?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvbmluaV9ib29t/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/SouthEast)

**同时VarList重写了Equals和GetHashCode接口，可以作为Dictionary的key和value，可以和Dictionary组成复杂的数据结构，极大地丰富数据类型，实现原理会在后续介绍。**







