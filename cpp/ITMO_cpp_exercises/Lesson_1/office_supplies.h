namespace office_supplies
{
    double measure(Polygon polygon, int num_of_points, int sum)
    {
        for(int p_ix = 0; p_ix < num_of_points; p_ix++)
        {
            int positive_pair = polygon.points[p_ix][0]*polygon.points[p_ix+1][1];
            int negative_pair = -polygon.points[p_ix][1]*polygon.points[p_ix+1][0];
            sum = sum + positive_pair + negative_pair;
        }
        return (double)sum/2;
    }
}
    
    //void set_point_for_pentagon(int shape)
    //{
    //    for(int p_ix = 0; p_ix <= 4; p_ix++)
    //    {
    //        cout << "Enter coordinates for point " << (p_ix+1) << endl;
    //        cin >> shape[p_ix][0];
    //        //cin >> shape[&point_ix][int *1];

