﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.Chapter2
{
    public class Page6 : IStaticCodeBook
    {
        public int Dimensions = 2;

        public byte[] LengthList = {
            1, 4, 3, 6, 6, 8, 8, 9, 9, 9, 9, 9, 9, 10, 10, 11,
            11, 0, 7, 7, 7, 7, 8, 8, 9, 9, 9, 9, 10, 10, 11, 11,
            12, 11, 0, 7, 7, 7, 7, 8, 8, 9, 9, 9, 9, 10, 10, 11,
            11, 11, 12, 0, 8, 8, 7, 7, 9, 9, 10, 10, 9, 9, 10, 10,
            11, 11, 12, 12, 0, 0, 0, 7, 7, 9, 9, 10, 10, 10, 9, 10,
            10, 11, 11, 12, 12, 0, 0, 0, 8, 8, 9, 9, 10, 10, 10, 10,
            11, 11, 11, 11, 12, 12, 0, 0, 0, 8, 8, 9, 9, 10, 10, 10,
            10, 11, 11, 12, 12, 12, 12, 0, 0, 0, 9, 9, 9, 9, 10, 10,
            10, 10, 11, 11, 12, 12, 12, 12, 0, 0, 0, 0, 0, 9, 9, 10,
            10, 10, 10, 11, 11, 12, 12, 13, 13, 0, 0, 0, 0, 0, 9, 9,
            10, 10, 11, 11, 11, 11, 12, 12, 13, 13, 0, 0, 0, 0, 0, 9,
            9, 10, 10, 11, 11, 11, 11, 12, 12, 13, 13, 0, 0, 0, 0, 0,
            10, 10, 10, 10, 11, 11, 12, 12, 13, 12, 13, 13, 0, 0, 0, 0,
            0, 0, 0, 10, 10, 11, 11, 12, 12, 13, 13, 13, 13, 0, 0, 0,
            0, 0, 0, 0, 11, 11, 12, 12, 12, 12, 13, 13, 13, 14, 0, 0,
            0, 0, 0, 0, 0, 11, 11, 12, 12, 12, 12, 13, 13, 13, 14, 0,
            0, 0, 0, 0, 0, 0, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 12, 12, 13, 13, 13, 13, 14,
            14
        };

        public CodeBookMapType MapType = CodeBookMapType.Implicit;
        public int QuantMin = -529530880;
        public int QuantDelta = 1611661312;
        public int Quant = 5;
        public int QuantSequenceP = 0;

        public int[] QuantList = {
            8,
            7,
            9,
            6,
            10,
            5,
            11,
            4,
            12,
            3,
            13,
            2,
            14,
            1,
            15,
            0,
            16
        };
    }
}