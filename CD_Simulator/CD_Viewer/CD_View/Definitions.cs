using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

using DispObject;
using CFigure;
namespace CD_View
{
    //*********************************************************************************************
    // interface for popup window
    //*********************************************************************************************

    public interface iPopupROI
    {
        void iOverlayStatusWrite(bool bDraw);
        bool iOverlayStatusRead();

        void iDrawROIWrite(bool bDraw);

        int iReadRoiCount();
        int iReadRoiIndex(Point pt);

        void iRemoveRoi(int nIndex);
        void iRemoveRoiAll();

        void iSaveROI(int nIndex);

        void iPTRN_Teach();
        
        //******************************************************************************************
        // for vertical rect pair

        void /*********/iMod_RectPair_DigonalAngle(int nIndex, int nAngle); // for angle adjustment

        //*****************************************************************************************
        // shared functions for paired figure 
        void iGet_CropsRectPairNormal(RectangleF rc1, RectangleF rc2, out byte[] crop1, out byte[] crop2);
        void iGet_CropsRectPairDigonal(CMeasurePairDig single, out byte[] crop1, out byte[] crop2);
        void iGet_CropsCircle(CMeasurePairCir single, out byte[] crop1, out byte[] crop2);

        //*****************************************************************************************
        // common functions for all figures

        void /********/iMod_Figure(object single, int nIndex);
        void /********/iAdj_Figure(int nFigureType, int nIndex, int nAction, int x, int y);
        void /********/iAdj_Overlay(int nAction, int nTarget, int nIndex,  int nDir, int nScale);
        void /********/iAdd_Figure(object figure);
        void /********/iDel_Figure(int nFigureType, int nIndex);
        object /******/iGet_Figure(int nFigureType, int nIndex);
        CFigureManager iGet_AllData();

        void iSetFigureDrawingActivation(bool bStatus);
        bool iGetFigureDrawingActivation();
        
    }

}
