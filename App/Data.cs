using System;
using System.Collections.Generic;
using App.Properties;
using Newtonsoft.Json;
using SharpRaven.Data;

namespace App
{
    public static class Data
    {
        public static bool Initialized { get; private set; } = false;
        public static decimal Version { get; private set; } = 0;

        public static Dictionary<int, Area> Areas { get; private set; } = new Dictionary<int, Area>();
        public static Dictionary<int, Instance> Instances { get; private set; } = new Dictionary<int, Instance>();
        public static Dictionary<int, Roulette> Roulettes { get; private set; } = new Dictionary<int, Roulette>();
        public static Dictionary<int, FATE> FATEs { get; private set; } = new Dictionary<int, FATE>();

        internal static void Initialize(string language)
        {
            string json;

            switch (language)
            {
                case "ko-kr":
                    json = Resources.Data_KO_KR;
                    break;

                case "en-us":
                    json = Resources.Data_EN_US;
                    break;

                default:
                    return;
            }

            Fill(json);
        }

        public static void Fill(string json)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<GameData>(json);

                var version = data.Version;

                if (version > Version)
                {
                    var fates = new Dictionary<int, FATE>();
                    foreach (var area in data.Areas)
                    {
                        foreach (var fate in area.Value.FATEs)
                        {
                            fate.Value.Area = area.Value;
                            fates.Add(fate.Key, fate.Value);
                        }
                    }

                    Areas = data.Areas;
                    Instances = data.Instances;
                    Roulettes = data.Roulettes;
                    FATEs = fates;
                    Version = version;

                    if (Initialized)
                    {
                        Log.S("l-data-updated", Version);
                    }

                    Initialized = true;
                }
                else
                {
                    Log.S("l-data-is-latest", Version);
                }
            }
            catch (Exception ex)
            {
                Log.Ex(ex, "l-data-error");
            }
        }

        internal static Instance GetInstance(int code)
        {
            if (Instances.TryGetValue(code, out var instance))
            {
                return instance;
            }

            if (code != 0)
            {
                var @event = new SentryEvent("Missing instance code");
                @event.Level = ErrorLevel.Warning;
                @event.Tags["code"] = code.ToString();
                Sentry.ReportAsync(@event);
            }

            return new Instance { Name = Localization.GetText("unknown-instance", code) };
        }

        internal static Roulette GetRoulette(int code)
        {
            if (Roulettes.TryGetValue(code, out var roulette))
            {
                return roulette;
            }

            if (code != 0)
            {
                var @event = new SentryEvent("Missing Roulette code");
                @event.Level = ErrorLevel.Warning;
                @event.Tags["code"] = code.ToString();
                Sentry.ReportAsync(@event);
            }

            return new Roulette { Name = Localization.GetText("unknown-roulette", code) };
        }

        internal static Area GetArea(int code)
        {
            if (Areas.TryGetValue(code, out var area))
            {
                return area;
            }

            if (code != 0)
            {
                var @event = new SentryEvent("Missing area code");
                @event.Level = ErrorLevel.Warning;
                @event.Tags["code"] = code.ToString();
                Sentry.ReportAsync(@event);
            }

            return new Area { Name = Localization.GetText("unknown-area", code) };
        }

        internal static FATE GetFATE(int code)
        {
            if (FATEs.ContainsKey(code))
            {
                return FATEs[code];
            }

            if (code != 0)
            {
                var @event = new SentryEvent("Missing FATE code");
                @event.Level = ErrorLevel.Warning;
                @event.Tags["code"] = code.ToString();
                Sentry.ReportAsync(@event);
            }

            return new FATE { Name = Localization.GetText("unknown-fate", code) };
        }

        public static string getFateNickName(string fateName)
        {
            //常风
            if(fateName.Contains("科里多仙人刺"))
            {
                return "仙人掌";
            }
            else if (fateName.Contains("常风领主"))
            {
                return "章鱼";
            }
            else if (fateName.Contains("忒勒斯"))
            {
                return "塞壬";
            }
            else if (fateName.Contains("常风皇帝"))
            {
                return "蜻蜓";
            }
            else if (fateName.Contains("卡利斯托"))
            {
                return "熊";
            }
            else if (fateName.Contains("群偶"))
            {
                return "群偶";
            }
            else if (fateName.Contains("哲罕南"))
            {
                return "卷心菜";
            }
            else if (fateName.Contains("阿米特"))
            {
                return "暴龙";
            }
            else if (fateName.Contains("盖因"))
            {
                return "盖因";
            }
            else if (fateName.Contains("庞巴德"))
            {
                return "举高高";
            }
            else if (fateName.Contains("塞尔凯特"))
            {
                return "皮皮虾";
            }
            else if (fateName.Contains("武断魔花茱莉卡"))
            {
                return "魔界花";
            }
            else if (fateName.Contains("白骑士"))
            {
                return "白骑士";
            }
            else if (fateName.Contains("波吕斐摩斯"))
            {
                return "独眼巨人";
            }
            else if (fateName.Contains("阔步西牟鸟"))
            {
                return "鸟";
            }
            else if (fateName.Contains("极其危险物质"))
            {
                return "肥宅";
            }
            else if (fateName.Contains("法夫纳"))
            {
                return "法夫纳";
            }
            else if (fateName.Contains("阿玛洛克"))
            {
                return "狗";
            }
            else if (fateName.Contains("拉玛什图"))
            {
                return "嫂子";
            }
            else if (fateName.Contains("帕祖祖"))
            {
                return "胖猪猪";
            }
            //恒冰
            else if (fateName.Contains("雪之女王"))
            {
                return "周冬雨";
            }
            else if (fateName.Contains("塔克西姆"))
            {
                return "举高高";
            }
            else if (fateName.Contains("灰烬龙"))
            {
                return "灰烬龙";
            }
            else if (fateName.Contains("异形魔虫"))
            {
                return "异形魔虫";
            }
            else if (fateName.Contains("安娜波"))
            {
                return "安娜波";
            }
            else if (fateName.Contains("白泽"))
            {
                return "白泽";
            }
            else if (fateName.Contains("雪屋王"))
            {
                return "雪屋王";
            }
            else if (fateName.Contains("阿萨格"))
            {
                return "阿萨格";
            }
            else if (fateName.Contains("苏罗毗"))
            {
                return "苏罗毗";
            }
            else if (fateName.Contains("亚瑟罗王"))
            {
                return "亚瑟罗王";
            }
            else if (fateName.Contains("唇亡齿寒"))
            {
                return "牛头";
            }
            else if (fateName.Contains("优雷卡圣牛"))
            {
                return "优雷卡圣牛";
            }
            else if (fateName.Contains("哈达约什"))
            {
                return "贝爷";
            }
            else if (fateName.Contains("荷鲁斯"))
            {
                return "荷鲁斯";
            }
            else if (fateName.Contains("总领安哥拉·曼纽"))
            {
                return "总领安哥拉曼纽";
            }
            else if (fateName.Contains("复制魔花凯西"))
            {
                return "魔界花";
            }
            else if (fateName.Contains("娄希"))
            {
                return "娄希";
            }
            else if (fateName.Contains("雪上的幸福兔")|| fateName.Contains("瞄准珊瑚的幸福兔"))
            {
                return "小兔子";
            }
            else if (fateName.Contains("盯上宝石的幸福兔")||fateName.Contains("困入岩石的幸福兔"))
            {
                return "大兔子";
            }
            //涌火
            else if (fateName.Contains("琉科西亚"))
            {
                return "琉科西亚";
            }
            else if (fateName.Contains("佛劳洛斯"))
            {
                return "佛劳洛斯";
            }
            else if (fateName.Contains("诡辩者"))
            {
                return "诡辩者";
            }
            else if (fateName.Contains("格拉菲亚卡内"))
            {
                return "格拉菲亚卡内";
            }
            else if (fateName.Contains("阿斯卡拉福斯"))
            {
                return "阿斯卡拉福斯";
            }
            else if (fateName.Contains("巴钦大公爵"))
            {
                return "巴钦大公爵";
            }
            else if (fateName.Contains("埃托洛斯"))
            {
                return "埃托洛斯";
            }
            else if (fateName.Contains("来萨特"))
            {
                return "来萨特";
            }
            else if (fateName.Contains("火巨人"))
            {
                return "火巨人";
            }
            else if (fateName.Contains("伊丽丝"))
            {
                return "伊丽丝";
            }
            else if (fateName.Contains("佣兵雷姆普里克斯"))
            {
                return "哥布林";
            }
            else if (fateName.Contains("闪电督军"))
            {
                return "雷军";
            }
            else if (fateName.Contains("垂柳树人"))
            {
                return "垂柳树人";
            }
            else if (fateName.Contains("明眸"))
            {
                return "明眸";
            }
            else if (fateName.Contains("阴阳"))
            {
                return "阴阳";
            }
            else if (fateName.Contains("斯库尔"))
            {
                return "冰狼";
            }
            else if (fateName.Contains("彭忒西勒亚"))
            {
                return "女人";
            }
            //丰水
            else if (fateName.Contains("卡拉墨鱼"))
            {
                return "墨鱼";
            }
            else if (fateName.Contains("剑齿象"))
            {
                return "大象";
            }
            else if (fateName.Contains("摩洛"))
            {
                return "摩洛";
            }
            else if (fateName.Contains("皮艾萨邪鸟"))
            {
                return "皮艾萨邪鸟";
            }
            else if (fateName.Contains("霜鬂猎魔"))
            {
                return "霜鬂猎魔";
            }
            else if (fateName.Contains("达佛涅"))
            {
                return "达佛涅";
            }
            else if (fateName.Contains("戈尔德马尔王"))
            {
                return "戈尔德马尔王";
            }
            else if (fateName.Contains("鲁尔克"))
            {
                return "鲁尔克";
            }
            else if (fateName.Contains("巴龙"))
            {
                return "狮子";
            }
            else if (fateName.Contains("刻托"))
            {
                return "刻托";
            }
            else if (fateName.Contains("起源守望者"))
            {
                return "水晶龙";
            }
            else if (fateName.Contains("兵武塔调查支援"))
            {
                return "兵武塔调查支援";
            }
            else if (fateName.Contains("未确认飞行物体"))
            {
                return "UFO";
            }
            else if (fateName.Contains("戏水的幸福兔"))
            {
                return "兔子";
            }
            else
            {
                return fateName;
            }
        }
    }
}
