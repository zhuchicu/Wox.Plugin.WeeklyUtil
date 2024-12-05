using System;
using System.Collections.Generic;  // 新增，用于 List<Result> 的依赖

namespace Wox.Plugin.WeeklyUtil
{
    public class Main : IPlugin
    {
        public void Init(PluginInitContext context){
            // TODO
        }

        public List<Result> Query(Query query){
            List<Result> results = new List<Result>();
            results.Add(new Result() {
                Title = "标题",
                SubTitle = "副标题",
                IcoPath = "Images\\plugin.png",  //相对于插件目录的相对路径
                Action = e => {
                    // 处理用户选择之后的操作
                    System.Windows.Forms.Clipboard.SetText("HelloWox!");
                    // 返回 false 告诉 Wox 不要隐藏查询窗体，返回 true 则会自动隐藏 Wox 查询窗口
                    return true;
                }
            });
            
            return results;
        }
    }
}