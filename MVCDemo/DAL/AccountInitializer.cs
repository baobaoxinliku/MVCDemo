using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCDemo.DAL
{
    public class AccountInitializer:DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var UserInfos = new List<UserInfo>
            {
                new UserInfo { UserName="admin",UserPwd="admin",UserEmail="admin@qq.com",Address="中山"},
                new UserInfo { UserName="唐门",UserPwd="tangmen",UserEmail="tangmen@qq.com",Address="中山"},
                new UserInfo { UserName="天香",UserPwd="tianxiang",UserEmail="tianxiang@qq.com",Address="佛山" },
                new UserInfo { UserName="真武",UserPwd="zhenwu",UserEmail="zhenwu@qq.com",Address="珠海" },
                new UserInfo { UserName="太白",UserPwd="taibai",UserEmail="taibai@qq.com" ,Address="广州"},
                new UserInfo { UserName="五毒",UserPwd="wudu",UserEmail="wudu@qq.com" ,Address="东莞"},
                new UserInfo { UserName="神威",UserPwd="shenwei",UserEmail="shenwei@qq.com" ,Address="韶关"},
                new UserInfo { UserName="丐帮",UserPwd="gaibang",UserEmail="gaibang@qq.com" ,Address="河源"},
                new UserInfo { UserName="神刀",UserPwd="shendao",UserEmail="shendao@qq.com" ,Address="梅州"}
            };
            UserInfos.ForEach(s => context.UserInfo.Add(s));

            var ScenicInfos = new List<ScenicInfo>
            {
                new ScenicInfo { ScenicName="九寨沟国家级自然保护区",ScenicCountry="中国",ScenicCity="四川省阿坝藏族羌族自治州",ScenicAddress="九寨沟县漳扎镇境内",ScenicType="野生动物类型自然保护区",ScenicLevel="世界自然遗产,国家AAAAA级旅游景区",ScenicIntro="九寨沟：世界自然遗产，世界生物圈保护区网络，国家AAAAA级旅游景区，国家级自然保护区，全国文明风景旅游区示范点，中国著名风景名胜区。"},
                new ScenicInfo { ScenicName="鼓浪屿",ScenicCountry="中国",ScenicCity="厦门市",ScenicAddress="厦门岛西南隅、九龙江入海口",ScenicType="著名的风景区",ScenicLevel="无",ScenicIntro="鼓浪屿（英文：Kulangsu）是福建省厦门市思明区下辖的一个街道。原名“圆沙洲”，别名“圆洲仔”，南宋时期命“五龙屿”明朝改称“鼓浪屿”。因涨潮水涌，浪击礁石，声似擂鼓而得名。鼓浪屿街道短小，纵横交错，是厦门最大的一个卫星岛之一。"},
                new ScenicInfo { ScenicName="香格里拉",ScenicCountry="中国",ScenicCity="云南省迪庆藏族自治州",ScenicAddress="云南省西北部",ScenicType="著名的旅游景点",ScenicLevel="无",ScenicIntro="香格里拉市是迪庆藏族自治州下辖市之一，市境位于云南省西北部，是滇、川及西藏三省区交汇处，也是“三江并流”风景区腹地。截至到2014年，香格里拉市总面积11613平方公里，辖4个镇、7个乡，共有6个社区、58个行政村。"},
                new ScenicInfo { ScenicName="北京故宫",ScenicCountry="中国",ScenicCity="北京市东城区",ScenicAddress="北京市东城区",ScenicType="世界遗产、历史古迹、历史博物馆",ScenicLevel="AAAAA级",ScenicIntro="北京故宫是中国明清两代的皇家宫殿，旧称为紫禁城，位于北京中轴线的中心，是中国古代宫廷建筑之精华。北京故宫以太三大殿为中心，占地72万平方米，建筑面积约15万平方米，有大小宫殿七十多座，房屋九千余间。是世界上现存规模最大、保存最为完整的木质结构古建筑之一。"},
                new ScenicInfo { ScenicName="崇明岛",ScenicCountry="中国",ScenicCity="上海市 ",ScenicAddress="中国华东，上海崇明县",ScenicLevel="无",ScenicType="著名的旅游景点",ScenicIntro="崇明岛地处长江口，是中国第三大岛，被誉为“长江门户、东海瀛洲”，是中国最大的河口冲积岛，中国最大的沙岛。崇明岛成陆已有1300多年历史，现有面积为1267平方公里，海拔3.5米～4.5米。全岛地势平坦，土地肥沃，林木茂盛，物产富饶，是有名的鱼米之乡。且该岛因为各种地理因素，面积每年增长约500公顷。"},
                new ScenicInfo { ScenicName="西湖",ScenicCountry="中国",ScenicCity="杭州",ScenicAddress="浙江杭州市",ScenicLevel="无",ScenicType="世界文化景观遗产",ScenicIntro="西湖，位于浙江省杭州市西面，是中国大陆首批国家重点风景名胜区和中国十大风景名胜之一。它是中国大陆主要的观赏性淡水湖泊之一，也是现今《世界遗产名录》中少数几个和中国唯一一个湖泊类文化遗产。"},
                new ScenicInfo { ScenicName="天山",ScenicCountry="中国、哈萨克斯坦等四国",ScenicCity="中国、哈萨克斯坦等四国",ScenicAddress="欧亚大陆腹地",ScenicLevel="世界自然遗产",ScenicType="世界七大山系之一",ScenicIntro="天山是世界七大山系之一，位于欧亚大陆腹地，东西横跨中国、哈萨克斯坦、吉尔吉斯斯坦和乌兹别克斯坦四国，全长约2500公里，南北平均宽250-350公里，最宽处达800公里以上。天山是世界上最大的独立纬向山系，也是世界上距离海洋最远的山系和全球干旱地区最大的山系。"},
                new ScenicInfo { ScenicName="世界博览会",ScenicCountry="世界",ScenicCity="中国",ScenicAddress="上海",ScenicLevel="无",ScenicType="国际性博览活动",ScenicIntro="世界博览会分为两种形式，一种是综合性世博会，另一种是专业性世博会。世博会是一项由主办国政府组织或政府委托有关部门举办的有较大影响和悠久历史的国际性博览活动。参展者向世界各国展示当代的文化、科技和产业上正面影响各种生活范畴的成果。"},
                new ScenicInfo { ScenicName="天津之眼",ScenicCountry="中国",ScenicCity="天津",ScenicAddress="天津市红桥区",ScenicLevel="五",ScenicType="天津的地标之一",ScenicIntro="天津之眼（The Tientsin Eye），全称天津永乐桥摩天轮（The Yongle Bridge Tientsin Eye），坐落在天津市红桥区海河畔，是一座跨河建设、桥轮合一的摩天轮，兼具观光和交通功用。是世界上唯一建在桥上的摩天轮，是天津的地标之一。"},
                new ScenicInfo { ScenicName="凤凰山 ",ScenicCountry="中国",ScenicCity="辽宁省丹东市凤城市",ScenicAddress="辽宁凤城",ScenicLevel="无",ScenicType="万里长城第一山",ScenicIntro="凤凰山位于辽宁省丹东市凤城市，由东山和西山两大景区组成，最高峰“攒云峰”海拔836米，面积216平方公里，凤凰山是奉天四大名山之一，辽东地区第一名山。被誉为“国门名山”、“万里长城第一山”、“中国历险第一名山”。唐贞观年间唐太宗李世民御驾东巡，游览此山时，有“凤凰拜祖”的传说，遂赐此山名为“凤凰山”。"},
                new ScenicInfo { ScenicName="澳门旅游塔",ScenicCountry="中国",ScenicCity="澳门",ScenicAddress="澳门西湾的新填海区",ScenicType="旅游景点",ScenicLevel="无",ScenicIntro="澳门旅游塔（葡文：Torre de Macau，英文：Macau Tower)，港澳地区习称为观光塔，是一座位于中华人民共和国澳门特别行政区的高塔。从地面到它的最高点，总高度为338米，1109英尺(56层）。主观光层位于离地面223米，732英尺高的位置。它是全球独立式观光塔第十位的观光塔，是世界高塔联盟的成员之一。"},
                new ScenicInfo { ScenicName="伊丽莎白塔",ScenicCountry="英国",ScenicCity="英格兰",ScenicAddress="英国伦敦泰晤士河畔",ScenicType="著名的旅游景点",ScenicLevel="无",ScenicIntro="伊丽莎白塔（Elizabeth Tower)，旧称大本钟(Big Ben)，即威斯敏斯特宫钟塔，世界上著名的哥特式建筑之一，英国国会会议厅附属的钟楼（Clock Tower）的大报时钟。是坐落在英国伦敦泰晤士河畔的一座钟楼，是伦敦的标志性建筑之一。钟楼高95米，钟直径7米，重13.5吨。每15分钟响一次，敲响威斯敏斯特钟声。自从兴建地铁Jubilee线之后，大本钟受到影响，测量显示大本钟朝西北方向倾斜约半米。"},
                new ScenicInfo { ScenicName="名古屋城",ScenicCountry="日本",ScenicCity="爱知县名古屋市",ScenicAddress="日本爱知县名古屋市",ScenicType="著名的旅游景点",ScenicLevel="无",ScenicIntro="名古屋城是位于日本爱知县名古屋市的城堡，江户时代是尾张藩藩主居城，别称“金城”、“金龇城”。其与大阪城，熊本城被合称为“日本三大名城”。"},
                new ScenicInfo { ScenicName="好莱坞",ScenicCountry="美国",ScenicCity="美国加利福尼亚州洛杉矶市",ScenicAddress="地处太平洋东侧的圣佩德罗湾和圣莫尼卡湾沿岸",ScenicType="著名的影视城",ScenicLevel="无",ScenicIntro="好莱坞（Hollywood），又称荷里活，位于美国西海岸加利福尼亚州洛杉矶郊外，依山傍水，景色宜人。"}
            };
            ScenicInfos.ForEach(s => context.ScenicInfo.Add(s));
        }
    }
}