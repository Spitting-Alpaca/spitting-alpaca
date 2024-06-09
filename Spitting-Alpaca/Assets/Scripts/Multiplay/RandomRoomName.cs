using UnityEngine;

public class RandomRoomName : MonoBehaviour
{
    string[] prefix = new string[] {
        "강력한",
        "활기찬",
        "귀여운",
        "최강",
        "국가권력급",
        "빛나는",
        "멋진",
        "행복한",
        "이쁜",
        "잘생긴",
        "멋있는",
        "귀여운",
        "배고픈",
        "배부른",
        "우울한",
        "활기찬",
        "사랑스러운",
        "밝은",
        "영리한",
        "재미있는",
        "강인한",
        "유능한",
        "창의적인",
        "당당한",
        "열정적인",
        "신중한",
        "정직한",
        "친절한",
        "대담한",
        "유쾌한",
        "평화로운",
        "세련된",
        "감사하는",
        "꾸준한",
        "용감한",
        "도전적인",
        "따뜻한",
        "풍부한",
        "안정적인",
        "섬세한",
        "쾌활한",
        "성실한",
        "믿음직한",
        "편안한",
        "부드러운",
        "정열적인",
        "기분 좋은",
        "흥미로운",
        "천재적인",
        "기쁜",
        "빛나는",
        "화려한",
        "감동적인",
        "매력적인",
        "신비로운",
        "희망찬",
        "끈기 있는",
        "감성적인",
        "공손한",
        "기운찬",
        "예의바른",
        "훌륭한",
        "신속한",
        "능숙한",
        "효율적인",
        "정교한",
        "실용적인",
        "우아한",
        "단호한",
        "놀라운",
        "유연한",
        "차분한",
        "신선한",
        "명랑한",
        "비범한",
        "관대한",
        "욕심없는",
        "정의로운",
        "뛰어난",
        "애정 어린",
        "우수한",
        "알찬",
        "존경하는",
        "출중한",
        "탁월한",
        "소중한",
        "혁신적인",
        "인내심 있는",
        "사려깊은",
        "순수한",
        "명확한",
        "확고한",
        "적극적인",
        "젊은",
        "매혹적인",
        "가벼운",
        "폭넓은",
        "능동적인",
        "맑은"
    };


    string[] subfix = new string[] {
        "알파카들의 방",
    };

    public string Generate()
    {
        string selectedPrefix = prefix[Random.Range(0, prefix.Length)];
        string selectedSubfix = subfix[Random.Range(0, subfix.Length)];

        return selectedPrefix + " " + selectedSubfix;
    }
}