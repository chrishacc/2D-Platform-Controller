﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myd.Platform.Demo
{
    //这里涉及坐标的数值需要/10, 除时间类型
    public interface Constants
    {
        const float Gravity = 90f; //重力

        const float HalfGravThreshold = 4f;
        const float MaxFall = -16; //普通最大下落速度
        const float FastMaxFall = -24f;  //快速最大下落速度
        const float FastMaxAccel = 30f; //快速下落加速度
        //最大移动速度
        const float MaxRun = 9f;
        //Hold情况下的最大移动速度
        const float HoldingMaxRun = 7f;
        //空气阻力
        const float AirMult = 0.65f;
        //移动加速度
        const float RunAccel = 100f;
        //移动减速度
        const float RunReduce = 40f;
        //
        const float JumpSpeed = 10.5f;  //最大跳跃速度
        const float VarJumpTime = 0.2f; //跳跃持续时间(跳起时,会持续响应跳跃按键[VarJumpTime]秒,影响跳跃的最高高度);
        const float JumpHBoost = 4f; //退离墙壁的力
        const float JumpGraceTime = 0.1f;//土狼时间

        #region WallJump
        public const float WallJumpCheckDist = 0.3f;
        public const float WallJumpForceTime = .16f; //墙上跳跃强制时间
        const float WallJumpHSpeed = MaxRun + JumpHBoost;

        #endregion

        #region SuperWallJump
        const float SuperJumpSpeed = JumpSpeed;
        const float SuperJumpH = 26f;
        const float SuperWallJumpSpeed = 16f;
        const float SuperWallJumpVarTime = .25f;
        const float SuperWallJumpForceTime = .2f;
        const float SuperWallJumpH = MaxRun + JumpHBoost* 2;
        #endregion
        #region WallSlide
        public const float WallSpeedRetentionTime = .06f; //撞墙以后可以允许的保持速度的时间
        public const float WallSlideTime = 1.2f; //墙壁滑行时间
        public const float WallSlideStartMax = -2f;
        
        
        #endregion

        #region Dash相关参数
        const float DashSpeed = 24f;           //冲刺速度
        const float EndDashSpeed = 16f;        //结束冲刺速度
        const float EndDashUpMult = .75f;       //如果向上冲刺，阻力。
        const float DashTime = .15f;            //冲刺时间
        const float DashCooldown = .2f;         //冲刺冷却时间，
        const float DashRefillCooldown = .1f;   //冲刺重新装填时间
        const int DashHJumpThruNudge = 6;       //
        const int DashCornerCorrection = 4;     //水平Dash时，遇到阻挡物的可纠正像素值
        const int DashVFloorSnapDist = 3;       //DashAttacking下的地面吸附像素值
        const float DashAttackTime = .3f;       //
        #endregion

        #region Climb参数
        public const float ClimbMaxStamina = 110;       //最大耐力
        public const float ClimbUpCost = 100 / 2.2f;   //向上爬得耐力消耗
        public const float ClimbStillCost = 100 / 10f; //爬着不动耐力消耗
        public const float ClimbJumpCost = 110 / 4f;   //爬着跳跃耐力消耗
        public const int ClimbCheckDist = 2;           //攀爬检查像素值
        public const int ClimbUpCheckDist = 2;         //向上攀爬检查像素值
        public const float ClimbNoMoveTime = .1f;
        public const float ClimbTiredThreshold = 20f;   //表现疲惫的阈值
        public const float ClimbUpSpeed = 4.5f;        //上爬速度
        public const float ClimbDownSpeed = -8f;       //下爬速度
        public const float ClimbSlipSpeed = -3f;       //下滑速度
        public const float ClimbAccel = 90f;          //下滑加速度
        public const float ClimbGrabYMult = .2f;       //攀爬时抓取导致的Y轴速度衰减
        public const float ClimbHopY = 12f;          //Hop的Y轴速度
        public const float ClimbHopX = 10f;           //Hop的X轴速度
        public const float ClimbHopForceTime = .2f;    //Hop时间
        public const float ClimbJumpBoostTime = .2f;   //WallBoost时间
        public const float ClimbHopNoWindTime = .3f;   //Wind情况下,Hop会无风0.3秒

        #endregion

        #region Duck参数
        const float DuckFriction = 50f;
        #endregion

        #region Corner Correct
        const float UpwardCornerCorrection = 4f; //向上移动，X轴上边缘校正的最大距离
        #endregion
    }
}