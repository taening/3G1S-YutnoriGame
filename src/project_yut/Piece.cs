using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_yut
{
    class Piece
    {
        private int position;
        private int previous_position;
        public bool initial;
        public bool goal;
        private bool isTeamRed;
        private Piece carry_pre;
        private Piece carry_next;

        public Piece(bool Team)
        {
            position = 0;
            previous_position = 0;
            initial = true;
            goal = false;
            isTeamRed = Team;
            carry_pre = null;
            carry_next = null;
        }

        public void display(List<PictureBox> picPlace)
        {
            if (initial || goal) return;
            if (carry_pre != null) return;

            int num = 0;
            search_ride(ref num);

            if (isTeamRed)
            {
                switch (num)
                {
                    case 1:
                        picPlace[position].Image = Properties.Resources.red1;
                        break;
                    case 2:
                        picPlace[position].Image = Properties.Resources.red2;
                        break;
                    case 3:
                        picPlace[position].Image = Properties.Resources.red3;
                        break;
                    case 4:
                        picPlace[position].Image = Properties.Resources.red4;
                        break;
                }
            }
            else
            {
                switch (num)
                {
                    case 1:
                        picPlace[position].Image = Properties.Resources.blue1;
                        break;
                    case 2:
                        picPlace[position].Image = Properties.Resources.blue2;
                        break;
                    case 3:
                        picPlace[position].Image = Properties.Resources.blue3;
                        break;
                    case 4:
                        picPlace[position].Image = Properties.Resources.blue4;
                        break;
                }
            }
        }

        private void search_ride(ref int num)
        {
            num++;
            if (this.carry_next != null) carry_next.search_ride(ref num);
        }

        public void move(ref int movement)
        {
            if(initial) {move_start(ref movement); return;}

            if (position == 0) { move_goal(ref movement); return; }
            else if (position == 19) { previous_position = position; position = 0; }
            else if ((position == 22) && (previous_position == 26)) { previous_position = position; position = 27; }
            else if (position == 24) { previous_position = position; position = 15; }
            else if (position == 26) { previous_position = position; position = 22; }
            else if (position == 28) { previous_position = position; position = 0; }
            else position++;

            if (carry_next != null) carry_next.move_ride(previous_position, position, initial, goal);
            movement--;
        }

        public void move_byway(ref int movement)
        {
            if (position == 5) { previous_position = position; position = 20; }
            else if (position == 10) { previous_position = position; position = 25; }
            else if (position == 22) { previous_position = position; position = 27; }
            else return;

            if (carry_next != null) carry_next.move_ride(previous_position, position, initial, goal);
            movement--;
        }

        private void move_start(ref int movement)
        {
            previous_position = position;
            position = 1;
            initial = false;
            goal = false;

            movement--;
        }

        private void move_goal(ref int movement)
        {
            previous_position = position;
            position = 0;
            initial = false;
            goal = true;

            if (carry_next != null) carry_next.move_ride(previous_position, position, initial, goal);
            movement = 0;
        }

        private void move_ride(int pre_pos, int pos, bool ini, bool end)
        {
            previous_position = pre_pos;
            position = pos;
            initial = ini;
            goal = end;
            if (carry_next != null) carry_next.move_ride(previous_position, position, initial, goal);
        }

        public bool die(Piece opposite)
        {
            if (this.carry_pre != null) return false;
            if (this.position != opposite.position) return false;
            
            die_ride();
            return true;
        }

        private void die_ride()
        {
            previous_position = 0;
            position = 0;
            initial = true;
            goal = false;

            if (carry_next != null) carry_next.die_ride();

            carry_pre = null;
            carry_next = null;
        }

        public bool carry(Piece same_team)
        {
            if (this.position != same_team.position) return false;
            if (this.carry_pre != null) return false;

            carry_ride(same_team);
            return true;
        }

        private void carry_ride(Piece same_team)
        {
            if (this.carry_next == null)
            {
                this.carry_next = same_team;
                same_team.carry_pre = this;
                same_team.previous_position = this.previous_position;
            }
            else this.carry_next.carry_ride(same_team);
        }

        public bool check_first()
        {
            if (carry_pre == null) return true;
            else return false;
        }

        public bool check_last()
        {
            if (carry_next == null) return true;
            else return false;
        }

        public void comm_LED(List<info_yut> infor)
        {
            if (carry_pre != null) return;
            if (initial || goal) return;

            for (int i = 0; i < infor.Count; i++)
            {
                if (position == infor[i].pos) return;
            }

            info_yut infor_piece;

            infor_piece.pos = position;

            if (isTeamRed) infor_piece.color = "R";
            else infor_piece.color = "B";

            int num = 0;
            search_ride(ref num);
            infor_piece.blink = num;

            infor.Add(infor_piece);
        }

        public void comm_select_LED(List<info_yut> infor)
        {
            info_yut infor_piece;

            infor_piece.pos = position;
            infor_piece.color = "RB";
            infor_piece.blink = 1;

            infor.Add(infor_piece);
        }

        public void comm_course(List<info_yut> infor, int movement, int goal_position)
        {
            bool isEnd = false;
            int course_position = position;

            comm_move_byway(ref course_position, ref movement);
            while (movement != 0) comm_move(ref course_position, ref movement, ref isEnd);

            if (isEnd)
            {
                info_yut info_piece_end;
                info_piece_end.pos = goal_position;
                if (isTeamRed) info_piece_end.color = "R";
                else info_piece_end.color = "B";
                info_piece_end.blink = 5;

                infor.Add(info_piece_end);
            }

            else
            {
                info_yut info_piece;
                info_piece.pos = course_position;
                if (isTeamRed) info_piece.color = "R";
                else info_piece.color = "B";
                info_piece.blink = 5;

                infor.Add(info_piece);
            }
        }

        private void comm_move(ref int course_position, ref int movement, ref bool isEnd)
        {
            if (!this.initial && course_position == 0) { movement = 0; isEnd = true; return; }
            else if (course_position == 19) course_position = 0;
            else if ((course_position == 22) && (previous_position == 26)) course_position = 27;
            else if (course_position == 24) course_position = 15;
            else if (course_position == 26) course_position = 22;
            else if (course_position == 28) course_position = 0;
            else course_position++;

            movement--;
        }

        private void comm_move_byway(ref int course_position, ref int movement)
        {
            if (course_position == 5) course_position = 20;
            else if (course_position == 10) course_position = 25;
            else if (course_position == 22) course_position = 27;
            else return;

            movement--;
        }
    }
}
