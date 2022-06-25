#include <iostream>
#include <cmath>
#include <string>

int generate_coordinate()

{
    srand(time(0));
    double num_1 = static_cast<double>(rand()) / static_cast<double>(1 + rand());
    double num_2 = static_cast<double>(rand()) / static_cast<double>(1 + rand());
    return (2 * num_1)/num_2;
    /*
    int coordinate;
    std::cout << "Set coordinate: ";
    std::cin >> coordinate;
    return coordinate;
    */
}

std::string get_rank(int total_score, int attempts)
{
    if(total_score == 100)
        return "Assasin";
    else if(total_score > 70)
        return "Sniper";
    else if(total_score > 50)
        return "Amateur";
    else if(total_score > 30)
        return "Well... could be better";
    else if(total_score > 10)
        return "You should aim when shooting you know...";
    else 
        return "Don't ever pick a gun up.";
}

double distance_from_centre(int *point)
{
    return sqrt(point[0]*point[0] + point[1]*point[1]);
}

bool is_on_target(int target_radius, int *point)
{
    return distance_from_centre(point) < target_radius;
}

void inform_player(int attempts,int total_score)
{
    std::cout << "Shooting results ====================" << std::endl;
    std::cout << "Shots: " + attempts << ". Score :" + total_score << "Average: " + (total_score/attempts)
              << "Rank: " + get_rank(total_score, attempts)
              << std::endl;
}

void shooting_gallery(
    int attempts, int radius_1, int radius_2, int radius_3)
{
    int dummy;
    std::cin.get();
    std::cout.precision(3);
    int shot[2];
    int *p_shot = shot;
    int total_score = 0;
    std::cout << "Press ENTER to shoot";

    for (int i = 0; i < attempts; i++)
    {
        shot[0] = generate_coordinate();
        shot[1] = generate_coordinate();

        /*if(is_on_target(radius_3, shot))
        {
            if(is_on_target(radius_2, shot))
            {
                if(is_on_target(radius_1, shot))
                {
                    total_score = total_score + 10;
                    std::cout << "Hit! "
                    << "[x: " << shot[0]
                        << " ,y: " << shot[1]
                            << " ]"<< std::endl;
                }
                else
                {
                    total_score = total_score + 5;
                    std::cout << "Hit! "
                    << "[x: " << shot[0]
                        << " ,y: " << shot[1]
                            << " ]"<< std::endl;
                }
            }
            else
            {
                total_score = total_score + 1;
                std::cout << "Hit! "
                    << "[x: " << shot[0]
                        << " ,y: " << shot[1]
                            << " ]"<< std::endl;
            }
        }
        else
            std::cout << "Miss! "
                << "[x: " << shot[0]
                    << " ,y: " << shot[1]
                        << " ]"<< std::endl;
        */
        double distance = distance_from_centre(shot);

        if(distance < radius_3)
        {
            if(distance < radius_2)
            {
                if(distance < radius_1)
                {
                    total_score = total_score + 10;
                    std::cout << "Hit! " << distance << " "
                        << "[x: " << *(p_shot)
                            << " ,y: " << *(p_shot+1)
                                << " ]"<< std::endl;
                    std::cin.get();
                }
                else
                {
                    total_score = total_score + 5;
                    std::cout << "Hit! " << distance << " "
                        << "[x: " << *(p_shot)
                            << " ,y: " << *(p_shot+1)
                                << " ]"<< std::endl;
                    std::cin.get();
                }
            }
            else
            {
                total_score = total_score + 1;
                std::cout << "Hit! " << distance << " "
                    << "[x: " << *(p_shot)
                        << " ,y: " << *(p_shot+1)
                            << " ]"<< std::endl;
                std::cin.get();
            }
        }
        else
        {
            std::cout << "Miss! " << distance << " "
                << "[x: " << *(p_shot)
                    << " ,y: " << *(p_shot+1)
                        << " ]"<< std::endl;
            std::cin.get();
        }
    }

    inform_player(attempts, total_score);
}