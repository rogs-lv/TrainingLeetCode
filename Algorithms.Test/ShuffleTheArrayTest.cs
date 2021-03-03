﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.Test
{
    public class ShuffleTheArrayTest
    {
        private ShuffleTheArray _shuffleTheArray;
        /// <summary>
        /// Constructor
        /// </summary>
        public ShuffleTheArrayTest() {
            _shuffleTheArray    = new ShuffleTheArray();
        }

        [Fact]
        public void TestCase1() {
            //Input
            int[] numsArray     = new int[] { 2, 5, 1, 3, 4, 7 };
            int elements        = 3;
            //Expected Output
            int[] outputArray   = new int[] { 2, 3, 5, 4, 1, 7 };
            var result      = _shuffleTheArray.Shuffle(numsArray, elements);
            Assert.Equal(outputArray, result);
        }
        [Fact]
        public void TestCase2() {
            //Input
            int[] numsArray     = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            int elements        = 4;
            //Expected Output
            int[] outputArray   = new int[] { 1, 4, 2, 3, 3, 2, 4, 1 };
            var result      = _shuffleTheArray.Shuffle(numsArray, elements);
            Assert.Equal(outputArray, result);
        }
        [Fact]
        public void TestCase3() {
            //Input
            int[] numsArray     = new int[] { 1, 1, 2, 2 };
            int elements        = 2;
            //Expected Output
            int[] outputArray   = new int[] { 1, 2, 1, 2 };
            var result      = _shuffleTheArray.Shuffle(numsArray, elements);
            Assert.Equal(outputArray, result);
        }
        [Fact]
        public void TestCase4() {
            //Input
            int[] numsArray     = new int[] { 7, 4, 9, 3, 4, 6, 7, 8, 1, 5 };
            int elements        = 5;
            //Expected Output
            int[] outputArray   = new int[] { 7, 6, 4, 7, 9, 8, 3, 1, 4, 5 };
            var result      = _shuffleTheArray.Shuffle(numsArray, elements);
            Assert.Equal(outputArray, result);
        }
        [Fact]
        public void TestCase5() {
            //Input
            int[] numsArray     = new int[] { 361, 681, 821, 914, 611, 137, 702, 8, 956, 598, 65, 921, 678, 476, 522, 961, 611, 752, 121, 756, 439, 640, 890, 171, 462, 942, 141, 832, 317, 251, 27, 824, 71, 781, 968, 177, 763, 43, 257, 430, 236, 612, 619, 3, 390, 900, 169, 427, 112, 628, 434, 891, 636, 68, 401, 720, 790, 651, 453, 668, 996, 870, 691, 705, 571, 241, 850, 897, 508, 345, 199, 568, 496, 691, 521, 826, 21, 887, 780, 561, 774, 713, 720, 689, 816, 135, 188, 4, 380, 248, 386, 112, 590, 588, 434, 366, 921, 913, 431, 149, 51, 272, 919, 766, 429, 865, 395, 945, 547, 575, 700, 903, 870, 891, 894, 283, 150, 2, 889, 437, 53, 846, 517, 260, 959, 88, 978, 908, 257, 155, 905, 107, 456, 632, 511, 502, 794, 954, 260, 951, 739, 243, 457, 805, 548, 483, 241, 698, 693, 152, 217, 919, 25, 994, 96, 204, 754, 659, 807, 342, 887, 487, 688, 392, 669, 593, 447, 239, 381, 393, 489, 195, 742, 937, 697, 810, 389, 712, 712, 476, 846, 280, 216, 105, 938, 986, 83, 462, 536, 307, 748, 135, 148, 918, 65, 253, 554, 66, 136, 955, 36, 2, 318, 300, 663, 22, 178, 88, 297, 286, 814, 42, 947, 331, 495, 607, 271, 583, 454, 683, 510, 985, 703, 74, 645, 354, 48, 823, 872, 445, 256, 324, 577, 756, 441, 844, 961, 915, 442, 916, 809, 994, 166, 250, 493, 706, 187, 816, 423, 457, 981, 970, 611, 452, 445, 51, 299, 245, 655, 309, 973, 354, 215, 851, 31, 490, 465, 192, 890, 651, 646, 356, 142, 537, 874, 515, 820, 453, 581, 938, 168, 231, 401, 415, 463, 285, 713, 125, 311, 390, 545, 716, 260, 134, 943, 456, 780, 314, 220, 3, 242, 995, 926, 772, 811, 626, 829, 74, 578, 929, 231, 846, 664, 716, 141, 742, 952, 799, 389, 746, 777, 340, 880, 500, 106, 929, 96, 9, 594, 419, 735, 506, 234, 579, 697, 173, 305, 629, 604, 837, 455, 639, 547, 382, 159, 699, 53, 544, 992, 201, 503, 980, 925, 473, 225, 901, 115, 426, 667, 882, 531, 821, 480, 160, 195, 724, 613, 86, 19, 968, 438, 324, 196, 552, 291, 138, 793, 499, 342, 406, 876, 551, 16, 394, 916, 754, 581, 760, 354, 796, 58, 879, 961, 722, 306, 634, 160, 388, 187, 435, 87, 967, 525, 25, 763, 179, 785, 374, 183, 88, 109, 616, 85, 261, 6, 979, 805, 86, 244, 440, 144, 852, 732, 223, 910, 559, 362, 474, 246, 657, 978, 406, 312, 907, 320, 909, 27, 991, 630, 737, 969, 208, 578, 267, 687, 442, 794, 701, 717, 327, 828, 74, 144, 747, 292, 234, 236, 302, 114, 205, 816, 311, 128, 525, 109, 703, 304, 178, 941, 96, 952, 813, 456, 506, 470, 935, 275, 465, 536, 468, 764, 661, 757, 919, 828, 904, 262, 565, 616, 86, 674, 725, 878, 426, 920, 659, 81, 53, 158, 984, 138, 617, 759, 621, 374, 16, 618, 638, 278, 356, 959, 770, 766, 645, 440, 156, 554, 209, 697, 205, 441, 739, 562, 855, 422, 228, 935, 30, 585, 811, 855, 223, 308, 551, 330, 147, 901, 136, 546, 812, 287, 624, 287, 260, 127, 903, 959, 233, 985, 765, 105, 872, 356, 953, 543, 399, 56, 904, 199, 146, 81, 589, 53, 466, 501, 737, 462, 215, 315, 294, 254, 418, 662, 884, 917, 817, 452, 302, 729, 518, 269, 702, 44, 820, 706, 982, 866, 355, 8, 931, 92, 997, 937, 400, 732, 698, 572, 821, 758, 390, 442, 744, 917, 692, 511, 686, 210, 472, 36, 726, 946, 753, 175, 680, 877, 378, 545, 232, 760, 518, 870, 107, 207, 384, 202, 257, 481, 263, 152, 220, 246, 631, 544, 339, 77, 524, 785, 351, 309, 20, 773, 395, 320, 282, 985, 339, 822, 257, 522, 355, 153, 340, 61, 240, 520, 335, 537, 534, 491, 255, 206, 946, 320, 815, 480, 315, 210, 836, 603, 353, 592, 194, 923, 740, 744, 475, 787, 924, 398, 863, 434, 224, 741, 797, 67, 905, 570, 304, 819, 742, 986, 252, 860, 54, 814, 827, 76, 504, 801, 670, 130, 986, 653, 169, 762, 959, 417, 321, 495, 45, 547, 613, 136, 628, 821, 981, 206, 523, 749, 575, 745, 905, 17, 860, 367, 341, 333, 869, 926, 917, 400, 283, 123, 728, 733, 448, 571, 572, 35, 108, 489, 250, 808, 774, 195, 374, 117, 233, 233, 832, 621, 552, 755, 227, 925, 224, 969, 792, 802, 421, 626, 547, 395, 578, 644, 265, 490, 407, 894, 373, 411, 634, 488, 641, 86, 496, 97, 242, 666, 992, 225, 101, 637, 94, 296, 847, 527, 896, 803, 510, 478, 778, 769, 614, 481, 942, 854, 231, 131, 930, 884, 709, 339, 859, 421, 987, 65, 114, 142, 429, 128, 727, 127, 810, 197, 526, 910, 301, 282, 796, 737, 593, 604, 384, 894, 633, 864, 874, 161, 144, 641, 865, 112, 735, 108, 516, 761, 777, 672, 308 };
            int elements        = 420;
            //Expected Output
            int[] outputArray   = new int[] { 361, 144, 681, 852, 821, 732, 914, 223, 611, 910, 137, 559, 702, 362, 8, 474, 956, 246, 598, 657, 65, 978, 921, 406, 678, 312, 476, 907, 522, 320, 961, 909, 611, 27, 752, 991, 121, 630, 756, 737, 439, 969, 640, 208, 890, 578, 171, 267, 462, 687, 942, 442, 141, 794, 832, 701, 317, 717, 251, 327, 27, 828, 824, 74, 71, 144, 781, 747, 968, 292, 177, 234, 763, 236, 43, 302, 257, 114, 430, 205, 236, 816, 612, 311, 619, 128, 3, 525, 390, 109, 900, 703, 169, 304, 427, 178, 112, 941, 628, 96, 434, 952, 891, 813, 636, 456, 68, 506, 401, 470, 720, 935, 790, 275, 651, 465, 453, 536, 668, 468, 996, 764, 870, 661, 691, 757, 705, 919, 571, 828, 241, 904, 850, 262, 897, 565, 508, 616, 345, 86, 199, 674, 568, 725, 496, 878, 691, 426, 521, 920, 826, 659, 21, 81, 887, 53, 780, 158, 561, 984, 774, 138, 713, 617, 720, 759, 689, 621, 816, 374, 135, 16, 188, 618, 4, 638, 380, 278, 248, 356, 386, 959, 112, 770, 590, 766, 588, 645, 434, 440, 366, 156, 921, 554, 913, 209, 431, 697, 149, 205, 51, 441, 272, 739, 919, 562, 766, 855, 429, 422, 865, 228, 395, 935, 945, 30, 547, 585, 575, 811, 700, 855, 903, 223, 870, 308, 891, 551, 894, 330, 283, 147, 150, 901, 2, 136, 889, 546, 437, 812, 53, 287, 846, 624, 517, 287, 260, 260, 959, 127, 88, 903, 978, 959, 908, 233, 257, 985, 155, 765, 905, 105, 107, 872, 456, 356, 632, 953, 511, 543, 502, 399, 794, 56, 954, 904, 260, 199, 951, 146, 739, 81, 243, 589, 457, 53, 805, 466, 548, 501, 483, 737, 241, 462, 698, 215, 693, 315, 152, 294, 217, 254, 919, 418, 25, 662, 994, 884, 96, 917, 204, 817, 754, 452, 659, 302, 807, 729, 342, 518, 887, 269, 487, 702, 688, 44, 392, 820, 669, 706, 593, 982, 447, 866, 239, 355, 381, 8, 393, 931, 489, 92, 195, 997, 742, 937, 937, 400, 697, 732, 810, 698, 389, 572, 712, 821, 712, 758, 476, 390, 846, 442, 280, 744, 216, 917, 105, 692, 938, 511, 986, 686, 83, 210, 462, 472, 536, 36, 307, 726, 748, 946, 135, 753, 148, 175, 918, 680, 65, 877, 253, 378, 554, 545, 66, 232, 136, 760, 955, 518, 36, 870, 2, 107, 318, 207, 300, 384, 663, 202, 22, 257, 178, 481, 88, 263, 297, 152, 286, 220, 814, 246, 42, 631, 947, 544, 331, 339, 495, 77, 607, 524, 271, 785, 583, 351, 454, 309, 683, 20, 510, 773, 985, 395, 703, 320, 74, 282, 645, 985, 354, 339, 48, 822, 823, 257, 872, 522, 445, 355, 256, 153, 324, 340, 577, 61, 756, 240, 441, 520, 844, 335, 961, 537, 915, 534, 442, 491, 916, 255, 809, 206, 994, 946, 166, 320, 250, 815, 493, 480, 706, 315, 187, 210, 816, 836, 423, 603, 457, 353, 981, 592, 970, 194, 611, 923, 452, 740, 445, 744, 51, 475, 299, 787, 245, 924, 655, 398, 309, 863, 973, 434, 354, 224, 215, 741, 851, 797, 31, 67, 490, 905, 465, 570, 192, 304, 890, 819, 651, 742, 646, 986, 356, 252, 142, 860, 537, 54, 874, 814, 515, 827, 820, 76, 453, 504, 581, 801, 938, 670, 168, 130, 231, 986, 401, 653, 415, 169, 463, 762, 285, 959, 713, 417, 125, 321, 311, 495, 390, 45, 545, 547, 716, 613, 260, 136, 134, 628, 943, 821, 456, 981, 780, 206, 314, 523, 220, 749, 3, 575, 242, 745, 995, 905, 926, 17, 772, 860, 811, 367, 626, 341, 829, 333, 74, 869, 578, 926, 929, 917, 231, 400, 846, 283, 664, 123, 716, 728, 141, 733, 742, 448, 952, 571, 799, 572, 389, 35, 746, 108, 777, 489, 340, 250, 880, 808, 500, 774, 106, 195, 929, 374, 96, 117, 9, 233, 594, 233, 419, 832, 735, 621, 506, 552, 234, 755, 579, 227, 697, 925, 173, 224, 305, 969, 629, 792, 604, 802, 837, 421, 455, 626, 639, 547, 547, 395, 382, 578, 159, 644, 699, 265, 53, 490, 544, 407, 992, 894, 201, 373, 503, 411, 980, 634, 925, 488, 473, 641, 225, 86, 901, 496, 115, 97, 426, 242, 667, 666, 882, 992, 531, 225, 821, 101, 480, 637, 160, 94, 195, 296, 724, 847, 613, 527, 86, 896, 19, 803, 968, 510, 438, 478, 324, 778, 196, 769, 552, 614, 291, 481, 138, 942, 793, 854, 499, 231, 342, 131, 406, 930, 876, 884, 551, 709, 16, 339, 394, 859, 916, 421, 754, 987, 581, 65, 760, 114, 354, 142, 796, 429, 58, 128, 879, 727, 961, 127, 722, 810, 306, 197, 634, 526, 160, 910, 388, 301, 187, 282, 435, 796, 87, 737, 967, 593, 525, 604, 25, 384, 763, 894, 179, 633, 785, 864, 374, 874, 183, 161, 88, 144, 109, 641, 616, 865, 85, 112, 261, 735, 6, 108, 979, 516, 805, 761, 86, 777, 244, 672, 440, 308 };
            var result      = _shuffleTheArray.Shuffle(numsArray, elements);
            Assert.Equal(outputArray, result);
        }
    }
}
