using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Project
{
    //시작과 끝만 내뚜고 다 쓸지도? Inn은 여관
    enum TileStyle
    {
        start = 0,
        //제일 바깥 타일들
        Village, Dungeon, Field, Mountain, Sea,
        //마을 내부 타일들
        Shop, Inn, Wall, Road,
        //동작? 타일들
        Monster, RandomBox, Player, NPC,
        //상세메뉴 타일들
        Shop_menu, Inn_menu, Battle_menu,
        //작동
        Eat, Rest, Gate,
        //던전 내부 타일들       
        end
    }


    struct Point
    {
        public int x;
        public int y;

        public Point(int _inputX, int _inputY)
        {
            x = _inputX;
            y = _inputY;
        }
        public void SetPosition(int _inputX, int _inputY)
        {
            x = _inputX;
            y = _inputY;
        }
    }


    internal class Tile
    {
        public string Image;
        public Point point;
        public TileStyle style;
        public int index;

        public Tile()
        {
            Image = "";
            point = new Point(0,0);
            style = TileStyle.start;
            index = 0;
        }
    }

    struct Rect
    {
        ////이건 몇번째 박스인가?
        //public int index;
        //어떤특수문자를 가지고있나?
        public string image;
        //각 박스별 너비
        public int width;
        //각 박스별 높이
        public int height;

        public Rect(int _width, int _height)
        {
            image = " ";
            width = _width;
            height = _height;
        }
    }


    class RectCase
    {
        //박스한칸
        public Rect[,] rect;
        public Tile[,] tile;

        //value x value 제작할 사이즈 조절용        
        public int length;

        //타일의 인덱스
        //public int[,] backGroundIndex;
        //타일의 이미지
        //public string backGround;

        public RectCase(int len, int width, int height)
        {
            length = len;
            tile = new Tile[1+len*height, 1+len*width];
            rect = new Rect[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    rect[i, j] = new Rect(width, height);
                }
            }

            for(int i = 0; i < tile.GetLength(0); i++)
            {
                for(int j = 0;j < tile.GetLength(1); j++)
                {
                    tile[i, j] = new Tile();
                }
            }


        }


        //public int[,] backGroundIndex;      //각 배열 인덱스값
        //public string[] backGround;         //인덱스별로 가지고있을 특수문자.

        //public int width;                   //각 박스별 너비
        //public int height;                  //각 박스별 높이




    }

    enum MapsName
    {
        World, Dungeon, Village,
        Shop, Inn
    }




}
