- [项目总结](#项目总结)
  - [了解到unity GameObject 概念](#了解到unity-gameobject-概念)
  - [了解到unity 预制体 概念](#了解到unity-预制体-概念)
  - [了解到unity排序图层概念](#了解到unity排序图层概念)
  - [知道了如何给GameObject添加脚本](#知道了如何给gameobject添加脚本)
  - [没有用到的游戏资源一定要销毁](#没有用到的游戏资源一定要销毁)
  - [如何制作动图](#如何制作动图)
  - [了解到unity 组件 概念](#了解到unity-组件-概念)
  - [transform上有一些位置相关的属性和方法](#transform上有一些位置相关的属性和方法)
  - [Start方法](#start方法)
  - [Update方法](#update方法)
  - [资料](#资料)

### 项目总结

#### 了解到unity GameObject 概念

  所有东西都是一个GameObject，可以通过脚本动态设置一些东西

#### 了解到unity 预制体 概念

  相当与一个带脚本或一些配置的组件，可以再游戏中重复使用。比如游戏中的子弹。将一个GameObject拖到resource中就是各预制体了。

#### 了解到unity排序图层概念

#### 知道了如何给GameObject添加脚本

  直接将脚本文件拖到GameObject上，就能将脚本和GameObject绑定，并在脚本里动态设置一些东西，如组件的一些属性

#### 没有用到的游戏资源一定要销毁

#### 如何制作动图

将不同的图片拖动到GameObject上。

#### 了解到unity 组件 概念

  添加的组件可以通过绑定的脚本动态设置一些东西

  ```c#
  Rigidbody2D birdRig;
  ...
  // 获取 2D Rigidbody 组件
  birdRig = this.GetComponent<Rigidbody2D>();
  ```

#### transform上有一些位置相关的属性和方法

  ```c#
  // 向左匀速移动，这个速度有问题，会根据每一帧的时间变换而变换
   this.transform.Translate(Vector2.left * speed * Time.deltaTime)
  ```

#### Start方法

  游戏运行时执行

#### Update方法

  GameObject每一帧需要做的事情

#### 资料

<https://github.com/xglofter/FlappyBird>  
<https://www.bilibili.com/video/BV1Y7411o71p>  
